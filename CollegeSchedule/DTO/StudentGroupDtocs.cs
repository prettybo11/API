namespace CollegeSchedule.DTO
{
    public class StudentGroupDto
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public int Course { get; set; }
        public string SpecialtyName { get; set; } = null!;
    }
}
