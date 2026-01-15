using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("subject")]
    public class Subject
    {
        [Key]
        [Column("subject_id")]
        public int SubjectId { get; set; }
        [Column("name")]
        [Required]
        public string Name { get; set; } = null!;
    }
}