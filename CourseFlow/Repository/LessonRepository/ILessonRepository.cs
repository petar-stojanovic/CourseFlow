using CourseFlow.Models;

namespace CourseFlow.Repository.LessonRepository;

public interface ILessonRepository
{
    Lesson CreateLesson(Lesson lesson);

    Lesson GetLesson(Guid lessonId);

    Lesson UpdateLesson(Lesson lesson);

    void DeleteLesson(Guid lessonId);
}