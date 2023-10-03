using CourseFlow.Data;
using CourseFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseFlow.Repository.LessonRepository;

public class LessonRepository: ILessonRepository
{
    private readonly DataContext _context;

    public LessonRepository(DataContext context)
    {
        _context = context;
    }

    public Lesson CreateLesson(Lesson lesson)
    {
        _context.Lessons.Add(lesson);
        _context.SaveChanges();
        return lesson;
    }

    public Lesson GetLesson(Guid lessonId)
    {
        return _context.Lessons.FirstOrDefault(lesson => lesson.Id == lessonId);
    }

    public List<Lesson> GetAllLessons()
    {
        return _context.Lessons.ToList();
    }

    public Lesson UpdateLesson(Lesson lesson)
    {
        _context.Lessons.Update(lesson);
        _context.SaveChanges();
        return lesson;
    }

    public void DeleteLesson(Guid lessonId)
    {
        var lessonToDelete = _context.Lessons.FirstOrDefault(lesson => lesson.Id == lessonId);
        if (lessonToDelete != null)
        {
            _context.Lessons.Remove(lessonToDelete);
            _context.SaveChanges();
        }
    }

}