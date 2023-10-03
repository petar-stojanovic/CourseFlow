namespace CourseFlow.Models;

public class UserTakesCourse
{
    public Guid UserId { get; set; }

    public Guid CourseId { get; set; }

    public User User { get; set; }

    public Course Course { get; set; }
}