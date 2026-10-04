using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    [PrimaryKey(nameof(teacher), nameof(discipline))]
    // Указываем точное имя таблицы в БД, чтобы EF Core не добавлял 's' в конце.
    // Նշում ենք աղյուսակի ճշգրիտ անունը ԲԴ-ում, որպեսզի EF Core-ը վերջում 's' չավելացնի։
    [Table("TeachersDisciplinesRelation")]
    public class TeachersDisciplinesRelation
    {
        
        [Column(TypeName = "SMALLINT")]
        [ForeignKey(nameof(Teacher))]
        public int teacher { get; set; }

        
        [Column(TypeName = "SMALLINT")]
        [ForeignKey(nameof(Discipline))]
        public int discipline { get; set; }

        //Navigation properties
        public Teacher Teacher { get; set; }    
        public Discipline Discipline { get; set; }
    }
}
