using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    [Table("Disciplines")]
    public class Discipline
    {
        [Key]
        [Column("discipline_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short DisciplineId { get; set; }

        [Column("discipline_name")]
        [StringLength(150)]
        public string? DisciplineName { get; set; }

        [Column("number_of_lessons")]
        public byte? NumberOfLessons { get; set; }
    }
}
