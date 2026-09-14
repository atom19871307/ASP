using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAcademy.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Column("stud_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Column("last_name")]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Column("first_name")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        [StringLength(50)]
        public string? MiddleName { get; set; }

        [Column("birth_date")]
        public DateOnly? BirthDate { get; set; }

        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }

        [Column("phone")]
        [StringLength(16)]
        public string? Phone { get; set; }

        [Column("photo")]
        public byte[]? Photo { get; set; }

        [Column("group")]
        public int? GroupId { get; set; }

        [ForeignKey("GroupId")]
        public Group? Group { get; set; }
    }
}
