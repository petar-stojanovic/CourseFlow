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
}