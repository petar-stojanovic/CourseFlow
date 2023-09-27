namespace CourseFlow.Models;

public class Course : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    // TODO()
    // public User Author { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public int Price { get; set; } = 0;

    public DateTime DateCreated { get; set; } = DateTime.Now;

    public bool IsPublic { get; set; } = false;

    public ICollection<Lesson> Lessons { get; set; }

    public ICollection<CourseCategory> CourseCategories { get; set; }
}