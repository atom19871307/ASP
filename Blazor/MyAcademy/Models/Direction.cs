using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    [Table("Directions")]
    public class Direction
    {
        [Key]
        [Column("direction_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte DirectionId { get; set; }

        [Column("direction_name")]
        [StringLength(50)]
        public string? DirectionName { get; set; }
    }
}