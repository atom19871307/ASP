using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string? Article { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Category { get; set; }

        [StringLength(50)]
        public string? Packaging { get; set; }

        [StringLength(20)]
        public string? Unit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        public int? ShelfLifeDays { get; set; }

        public int QuantityInStock { get; set; }

        public DateOnly? ExpiryDate { get; set; }
    }
}