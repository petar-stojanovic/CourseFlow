using CourseFlow.Data;
using CourseFlow.DTO;
using CourseFlow.Models;
using CourseFlow.Repository.CourseRepository;
using CourseFlow.Repository.LessonRepository;
using Microsoft.AspNetCore.Mvc;

namespace CourseFlow.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LessonController : ControllerBase
{
    private readonly ILessonRepository _lessonRepository;
    private readonly DataContext _context;

    public LessonController(ILessonRepository lessonRepository, DataContext dataContext)
    {
        _lessonRepository = lessonRepository;
        _context = dataContext;
    }

    [HttpGet("{courseId}")]
    public ActionResult<List<Lesson>> GetLessonsForCourse(Guid courseId)
    {
        return _lessonRepository.GetLessonsByCourse(courseId);
    }

    [HttpPost("completeLesson")]
    public IActionResult CompleteLesson([FromBody] LessonCompleteDTO request)
    {
        // Retrieve the user's UserTakesCourse entity based on userId and courseId
        var userTakesCourse = _context.UserTakesCourses
            .SingleOrDefault(utc => utc.UserId == request.userId && utc.CourseId == request.courseId);

        if (userTakesCourse == null)
        {
            return NotFound("User course not found");
        }

        // Convert the list of completed lesson IDs to a comma-separated string
        string completedLessonIds = string.Join(",", userTakesCourse.CompletedLessonIds);

        // Check if the lessonId is not already in the list
        if (!completedLessonIds.Contains(request.lessonId.ToString()))
        {
            if (!string.IsNullOrEmpty(completedLessonIds))
            {
                completedLessonIds += ",";
            }

            completedLessonIds += request.lessonId.ToString();

            // Update the CompletedLessonIds property
            userTakesCourse.CompletedLessonIds = completedLessonIds;

            // Save changes to persist the updated completed lesson list
            _context.SaveChanges();
        }

        return Ok(completedLessonIds);
    }

    [HttpGet("userProgress")]
    public IActionResult GetUserProgress(Guid userId, Guid courseId)
    {
        // Retrieve the user's UserTakesCourse entity based on userId and courseId
        var userTakesCourse = _context.UserTakesCourses
            .SingleOrDefault(utc => utc.UserId == userId && utc.CourseId == courseId);

        if (userTakesCourse == null)
        {
            return NotFound("User course not found");
        }

        var course = _context.Courses
            .SingleOrDefault(c => c.Id == courseId);

        if (course == null)
        {
            return NotFound("Course not found");
        }

        
        if (userTakesCourse.CompletedLessonIds.Equals(""))
        {
            return Ok(new
            {
                CompletedLessons = "",
                ProgressPercentage = 0
            });
        }

        var completedLessonsCount = userTakesCourse.CompletedLessonIds.Split(",").Length;

        var totalLessonsCount = _context.Lessons.Count(l => l.Course.Id == courseId);

        var progressPercentage = totalLessonsCount > 0 ? (completedLessonsCount * 100) / totalLessonsCount : 0;

        userTakesCourse.Progress = progressPercentage;
        _context.UserTakesCourses.Update(userTakesCourse);
        if (progressPercentage == 100)
        {
            userTakesCourse.EndDate = DateTime.Now;
            _context.UserTakesCourses.Update(userTakesCourse);
        }

        _context.SaveChanges();

        return Ok(new
        {
            CompletedLessons = userTakesCourse.CompletedLessonIds.Split(","),
            ProgressPercentage = progressPercentage
        });
    }
}