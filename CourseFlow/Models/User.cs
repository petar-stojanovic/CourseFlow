namespace CourseFlow.Models;

public class User: BaseEntity
{
    public string Username { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;

    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    
    public string AuthToken { get; set; } = string.Empty;

    
    public ICollection<AuthorCourses> AuthorCourses { get; set; }
    public ICollection<UserTakesCourse> UserTakesCourse { get; set; }

}