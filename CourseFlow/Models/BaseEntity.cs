using System.ComponentModel.DataAnnotations;

namespace CourseFlow.Models;

public class BaseEntity
{ 
    [Key]
    public Guid Id { get; set; }
}
