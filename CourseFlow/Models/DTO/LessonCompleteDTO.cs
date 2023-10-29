namespace CourseFlow.DTO;

public class LessonCompleteDTO
{
    public Guid userId { get; set; }
    public Guid courseId { get; set; }
    public Guid lessonId { get; set; }
}