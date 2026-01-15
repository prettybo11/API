using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("student_group")]
    public class StudentGroup
    {
        [Key]
        [Column("group_id")]
        public int GroupId { get; set; }
        [Column("group_name")]
        [Required]
        public string GroupName { get; set; } = null!;
        [Column("course")]
        public int Course { get; set; }
        [Column("specialty_id")]
        public int SpecialtyId { get; set; }
        [ForeignKey("SpecialtyId")]
        public Specialty Specialty { get; set; } = null!;
    }
}