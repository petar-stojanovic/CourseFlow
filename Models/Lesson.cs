namespace CourseFlow.Models;

public class Lesson : BaseEntity
{
    public string Description { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;
}