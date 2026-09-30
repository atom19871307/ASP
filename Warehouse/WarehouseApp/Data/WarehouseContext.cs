using Microsoft.EntityFrameworkCore;
using WarehouseApp.Models;

namespace WarehouseApp.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}