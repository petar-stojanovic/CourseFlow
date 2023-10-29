using System.Diagnostics;
using CourseFlow.Data;
using CourseFlow.DTO;
using CourseFlow.Models;
using CourseFlow.Repository.CourseRepository;
using CourseFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace CourseFlow.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ICourseRepository _courseRepository;

    private readonly DataContext _context;

    public CourseController(ICourseRepository courseRepository, DataContext dataContext)
    {
        _courseRepository = courseRepository;
        _context = dataContext;
    }

    [HttpGet("")]
    public ActionResult<List<Course>> Get()
    {
        return _courseRepository.GetAllCourses();
    }

    [HttpGet("{courseId}")]
    public ActionResult<Course> GetCourseById(Guid courseId)
    {
        return _courseRepository.GetCourse(courseId);
    }

    [HttpGet("private")]
    public ActionResult<List<Course>> GetAllPrivate()
    {
        return _courseRepository.GetAllPrivateCourses();
    }

    [HttpGet("public")]
    public ActionResult<List<Course>> GetAllPublic()
    {
        return _courseRepository.GetAllPublicCourses();
    }


    [HttpPost("create")]
    public async Task<IActionResult> CreateCourse([FromBody] CourseDTO courseDto)
    {
        //https://www.googleapis.com/youtube/v3/videos?key=AIzaSyBG5w-C-WIR25POwPlSQBZmFWAd6HjgNyM&part=contentDetails&id=dQw4w9WgXcQ
        if (courseDto == null)
        {
            return BadRequest("Invalid course data");
        }

        // Map the CourseInputModel to your Course entity
        Course course;
        if (courseDto.Lessons != null)
        {
            course = new Course
            {
                Title = courseDto.Title,
                Description = courseDto.Description,
                Author = courseDto.Author.Username,
                Thumbnail = courseDto.Thumbnail,
                Price = courseDto.Price,
                Lessons = courseDto.Lessons.Select(lessonInput => new Lesson
                {
                    Description = lessonInput.Description,
                    Url = lessonInput.Url
                }).ToList()
            };
        }
        else
        {
            course = new Course
            {
                Id = Guid.NewGuid(),
                Title = courseDto.Title,
                Description = courseDto.Description,
                Author = courseDto.Author.Username,
                Thumbnail = courseDto.Thumbnail,
                Price = courseDto.Price,
                Lessons = _context.Lessons.Where(l =>
                        l.Course.Title == "Admin" && l.Course.Description == "This is a course for unassigned lessons")
                    .ToList()
            };
            var lessons = _context.Lessons.Where(l =>
                l.Course.Title == "Admin" && l.Course.Description == "This is a course for unassigned lessons");
            foreach (var lesson in lessons)
            {
                lesson.Course = course;
                _context.Lessons.Update(lesson);
            }
        }


        //TODO            Categories = courseDto.Categories,

        foreach (var cat in courseDto.Categories)
        {
            var category = new CourseCategory
            {
                Category = _context.Categories.FirstOrDefault(c => c.Id.ToString() == cat),
                Course = course,
                CourseId = course.Id,
                CategoryId = _context.Categories.FirstOrDefault(c => c.Id.ToString() == cat).Id
            };
            _context.CourseCategories.Add(category);
        }

        try
        {
            // Add the course and its related lessons to the database
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return Ok(course);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPost("createLessonsForCourse")]
    public async Task<IActionResult> CreateCourseLessonsFromFile(IFormFile file)
    {
        string pathToFile = $"{Directory.GetCurrentDirectory()}\\files\\{file.FileName}";


        await using (FileStream fileStream = System.IO.File.Create(pathToFile))
        {
            file.CopyTo(fileStream);
            fileStream.Flush();
        }

        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


        List<Lesson> lessonList = new List<Lesson>();

        using (var stream = System.IO.File.Open(pathToFile, FileMode.Open, FileAccess.Read))
        {
            using (var reader = new StreamReader(stream))
            {
                string readerLine;
                while ((readerLine = reader.ReadLine()) != null)
                {
                    Debug.WriteLine(readerLine);
                    var line = readerLine.Split(",");
                    string videoUrl = line[1];
                    YouTubeVideoData videoData = await GetYoutubeLinkDetails(videoUrl);

                    var lesson = new Lesson
                    {
                        Description = line[0],
                        Url = videoUrl,
                        Title = videoData.title,
                        Thumbnail = videoData.thumbnail_url,
                        Course = _context.Courses.FirstOrDefault(c =>
                            c.Title == "Admin" && c.Description == "This is a course for unassigned lessons")!
                    };
                    lessonList.Add(lesson);
                }
            }
        }

        foreach (var lesson in lessonList)
        {
            _context.Lessons.Add(lesson);
        }

        await _context.SaveChangesAsync();

        return StatusCode(200, $"OK YEY {pathToFile}");
    }

    [HttpPost("enroll")]
    public async Task<IActionResult> EnrollUserToCourse([FromBody] UserTakesCourseDTO userTakesCourseDto)
    {
        var userTakesCourse = new UserTakesCourse
        {
            UserId = userTakesCourseDto.UserId,
            CourseId = userTakesCourseDto.CourseId,
            User = _context.Users.FirstOrDefault(u => u.Id == userTakesCourseDto.UserId),
            Course = _context.Courses.FirstOrDefault(c => c.Id == userTakesCourseDto.CourseId),
            StartDate = DateTime.Now,
            Progress = 0
        };


        try
        {
            _context.UserTakesCourses.Add(userTakesCourse);
            await _context.SaveChangesAsync();
            return Ok(userTakesCourse);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }


    [HttpPost("checkUserTakesCourse")]
    public async Task<bool> CheckUserTakesCourse([FromBody] UserTakesCourseDTO userTakesCourseDto)
    {
        var userTakesCourse = _context.UserTakesCourses.FirstOrDefault(utc =>
            utc.CourseId == userTakesCourseDto.CourseId && utc.UserId == userTakesCourseDto.UserId);
        return userTakesCourse != null;
    }

    [HttpGet("makeCoursePublic/{courseId}")]
    public ActionResult<Course> MakeCoursePublic(Guid courseId)
    {
        var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
        // _context
        course.IsPublic = true;
        _context.SaveChanges();
        return course;
    }

    private async Task<YouTubeVideoData> GetYoutubeLinkDetails(string videoUrl)
    {
        // Construct the URL for the YouTube oEmbed API
        string oEmbedUrl = $"https://www.youtube.com/oembed?url={videoUrl}";

        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                // Send a GET request to the YouTube oEmbed API
                HttpResponseMessage response = await httpClient.GetAsync(oEmbedUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string responseBody = await response.Content.ReadAsStringAsync();
                    YouTubeVideoData videoData =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<YouTubeVideoData>(responseBody);
                    return videoData;
                }
                else
                {
                    // Handle the response error
                    throw new HttpRequestException($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle the exception (e.g., log or return an error response)
                throw ex;
            }
        }
    }


    [HttpPost("downloadCertificate")]
    public IActionResult DownloadCertificate([FromBody] UserTakesCourseDTO request)
    {
        // Retrieve the user's UserTakesCourse entity based on userId and courseId
        var userTakesCourse = _context.UserTakesCourses
            .SingleOrDefault(utc => utc.UserId == request.UserId && utc.CourseId == request.CourseId);


        if (userTakesCourse == null)
        {
            return NotFound("User course not found");
        }

        // Generate the PDF certificate
        CertificateGenerator certificateGenerator = new CertificateGenerator(_context);
        byte[] certificateBytes = certificateGenerator.GenerateCertificate(userTakesCourse);

        // Return the PDF certificate as a downloadable file
        return File(certificateBytes, "application/pdf", "Certificate.pdf");
    }
}