using System.ComponentModel.DataAnnotations.Schema;

namespace System.ComponentModel.DataAnnotations;

public class Direction
{
    [Key]
    [Column(TypeName = "TINYINT")]
    public int direction_id { get; set; }
    public string direction_name { get; set; }
}
