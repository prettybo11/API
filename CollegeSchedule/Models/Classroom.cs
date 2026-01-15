using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CollegeSchedule.Models
{
    [Table("classroom")]
    public class Classroom
    {
        [Key]
        [Column("classroom_id")]
        public int ClassroomId { get; set; }
        [Column("building_id")]
        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; } = null!;
        [Column("room_number")]
        [Required]
        public string RoomNumber { get; set; } = null!;
    }
}