namespace CourseFlow.Models;

public class CourseCategory
{
    public Guid CourseId { get; set; }

    public Guid CategoryId { get; set; }

    public Course Course { get; set; }

    public Category Category { get; set; }
}