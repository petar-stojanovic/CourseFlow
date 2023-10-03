namespace CourseFlow.Models;

public class AuthorCourses
{
    public Guid AuthorId { get; set; }

    public Guid CourseId { get; set; }

    public User Author { get; set; }

    public Course Course { get; set; }
}