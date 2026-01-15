using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("weekday")]
    public class Weekday
    {
        [Key]
        [Column("weekday_id")]
        public int WeekdayId { get; set; }
        [Column("name")]
        [Required]
        public string Name { get; set; } = null!;
    }
}