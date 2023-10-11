namespace CourseFlow.Models;

public class Course : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    
    public string Author { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Thumbnail { get; set; } = string.Empty;

    public int Price { get; set; } = 0;

    public DateTime DateCreated { get; set; } = DateTime.Now;

    public bool IsPublic { get; set; } = false;

    public ICollection<Lesson> Lessons { get; set; }

    public ICollection<CourseCategory> CourseCategories { get; set; }
    
    public ICollection<AuthorCourses> AuthorCourses { get; set; }
    
    public ICollection<UserTakesCourse> UserTakesCourse { get; set; }
    
}