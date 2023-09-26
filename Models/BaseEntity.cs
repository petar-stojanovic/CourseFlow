using System.ComponentModel.DataAnnotations;

namespace CourseFlow.Models;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
//    "DefaultConnection": "Server=YOURSERVER;User ID=YOURUSERID;Password=YOURPASSWORD;Database=YOURDATABASE",
