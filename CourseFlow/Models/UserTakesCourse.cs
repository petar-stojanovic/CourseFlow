using System.ComponentModel.DataAnnotations.Schema;

namespace CourseFlow.Models;

public class UserTakesCourse
{
    public Guid UserId { get; set; }

    public Guid CourseId { get; set; }

    public User User { get; set; }

    public Course Course { get; set; }

    public int Progress { get; set; } = 0;

    public DateTime StartDate { get; set; } = DateTime.Now;
    
    public DateTime? EndDate { get; set; }
    
    public string CompletedLessonIds { get; set; } = string.Empty;
}