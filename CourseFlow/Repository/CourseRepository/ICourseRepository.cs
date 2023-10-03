using CourseFlow.Models;

namespace CourseFlow.Repository.CourseRepository;

public interface ICourseRepository
{
    Course CreateCourse(Course course);

    Course GetCourse(Guid courseId);

    List<Course> GetAllCourses();

    Course UpdateCourse(Course course);

    void DeleteCourse(Guid courseId);

}