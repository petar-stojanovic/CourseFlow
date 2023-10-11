namespace CourseFlow.Models;

public class Lesson : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
   
    public string Thumbnail { get; set; } = string.Empty;
  
    public string Url { get; set; } = string.Empty;

    public Course Course { get; set; }
}