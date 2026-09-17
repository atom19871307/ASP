using Microsoft.EntityFrameworkCore;

public class AcademyContext(DbContextOptions<AcademyContext> options) : DbContext(options)
{
    public DbSet<System.ComponentModel.DataAnnotations.Direction> Directions { get; set; } = default!;
}
