using CourseFlow.Models;

namespace CourseFlow.DTO;

public class CourseDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Thumbnail { get; set; }
    public UserDTO Author { get; set; }
    public int Price { get; set; }
    public List<string> Categories { get; set; }
    public List<LessonDTO> Lessons { get; set; }

}

public class LessonDTO
{
    public string Description { get; set; }
    public string Url { get; set; }
}

public class UserDTO
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}