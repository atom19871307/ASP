using Microsoft.EntityFrameworkCore;
using MyAcademy.Models;

namespace MyAcademy
{
    public class MyAcademyContext : DbContext
    {
        public MyAcademyContext(DbContextOptions<MyAcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Direction> Directions { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Rate)
                .HasPrecision(18, 2);
        }
    }
}