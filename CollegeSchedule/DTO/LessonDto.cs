using CollegeSchedule.Models;
namespace CollegeSchedule.DTO
{
    public class LessonDto
    {
        public int LessonNumber { get; set; }
        public string Time { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Teacher { get; set; } = null!;
        public string TeacherPosition { get; set; } = null!;
        public string Classroom { get; set; } = null!;
        public string Building { get; set; } = null!;
        public string Address { get; set; } = null!;
        public Dictionary<LessonGroupPart, LessonPartDto?> GroupParts { get; set; } =
        new();
    }
}