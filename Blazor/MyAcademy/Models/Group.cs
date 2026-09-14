using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    [Table("Groups")]
    public class Group
    {
        [Key]
        [Column("group_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GroupId { get; set; }

        [Column("group_name")]
        [StringLength(10)]
        public string? GroupName { get; set; }

        [Column("direction")]
        public byte? DirectionId { get; set; }

        [Column("start_date")]
        public DateOnly? StartDate { get; set; }

        [Column("start_time")]
        public TimeOnly? StartTime { get; set; }

        [Column("learning_days")]
        public byte? LearningDays { get; set; }

        [ForeignKey("DirectionId")]
        public Direction? Direction { get; set; }
    }
}
