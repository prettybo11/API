using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("schedule")]
    public class Schedule
    {
        [Key]
        [Column("schedule_id")]
        public int ScheduleId { get; set; }
        [Column("lesson_date", TypeName = "date")]
        public DateTime LessonDate { get; set; }
        [Column("weekday_id")]
        public int WeekdayId { get; set; }
        [ForeignKey("WeekdayId")]
        public Weekday Weekday { get; set; } = null!;
        [Column("lesson_time_id")]
        public int LessonTimeId { get; set; }
        [ForeignKey("LessonTimeId")]
        public LessonTime LessonTime { get; set; } = null!;
        [Column("group_id")]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public StudentGroup Group { get; set; } = null!;
        [Column("group_part")]
        public LessonGroupPart GroupPart { get; set; }
        [Column("subject_id")]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; } = null!;
        [Column("teacher_id")]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; } = null!;
        [Column("classroom_id")]
        public int ClassroomId { get; set; }
        [ForeignKey("ClassroomId")]
        public Classroom Classroom { get; set; } = null!;
    }
}