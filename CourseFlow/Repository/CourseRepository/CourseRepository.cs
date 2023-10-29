using CourseFlow.Data;
using CourseFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseFlow.Repository.CourseRepository;

public class CourseRepository : ICourseRepository
{
    private readonly DataContext _context;

    public CourseRepository(DataContext context)
    {
        _context = context;
    }

    public Course CreateCourse(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
        return course;
    }

    public Course GetCourse(Guid courseId)
    {
        return _context.Courses.FirstOrDefault(course => course.Id == courseId);
    }

    public List<Course> GetAllCourses()
    {
        return _context.Courses.ToList();
    }

    public List<Course> GetAllPrivateCourses()
    {
        return _context.Courses.Where(c =>
            c.IsPublic == false && c.Title != "Admin" &&
            c.Description != "This is a course for unassigned lessons").ToList();
    }

    public List<Course> GetAllPublicCourses()
    {
        return _context.Courses
            .Where(c => c.IsPublic == true)
            .Select(c => new Course
            {
                Id = c.Id,
                Title = c.Title,
                Author = c.Author,
                Description = c.Description,
                Thumbnail = c.Thumbnail,
                Price = c.Price,
                DateCreated = c.DateCreated,
                IsPublic = c.IsPublic,
                // Lessons = c.Lessons,
                CourseCategories = c.CourseCategories.Select(cc => new CourseCategory
                {
                    Category = new Category { Name = cc.Category.Name }
                }).ToList()
            })
            .ToList();    }

    public Course UpdateCourse(Course course)
    {
        _context.Courses.Update(course);
        _context.SaveChanges();
        return course;
    }

    public void DeleteCourse(Guid courseId)
    {
        var courseToDelete = _context.Courses.FirstOrDefault(course => course.Id == courseId);
        if (courseToDelete != null)
        {
            var courseCategoriesToDelete = _context.CourseCategories
                .Where(cc => cc.CourseId == courseId)
                .ToList();

            _context.CourseCategories.RemoveRange(courseCategoriesToDelete);


            _context.Courses.Remove(courseToDelete);
            _context.SaveChanges();
        }
    }
}