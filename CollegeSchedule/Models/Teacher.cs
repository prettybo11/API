using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("teacher")]
    public class Teacher
    {
        [Key]
        [Column("teacher_id")]
        public int TeacherId { get; set; }
        [Column("last_name")]
        [Required]
        public string LastName { get; set; } = null!;
        [Column("first_name")]
        [Required]
        public string FirstName { get; set; } = null!;
        [Column("middle_name")]
        public string? MiddleName { get; set; }
        [Column("position")]
        [Required]
        public string Position { get; set; } = null!;
    }
}