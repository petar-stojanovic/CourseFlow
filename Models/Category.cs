namespace CourseFlow.Models;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<CourseCategory> CourseCategories { get; set; }
}