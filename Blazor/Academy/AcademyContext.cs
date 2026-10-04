using Academy.Models;
using Microsoft.EntityFrameworkCore;

public class AcademyContext(DbContextOptions<AcademyContext> options) : DbContext(options)
{
    //DbSet-ы для всех таблиц базы данных.
    //DbSet-եր ԲԴ-ի բոլոր աղյուսակների համար։
    public DbSet<Academy.Models.Direction> Directions { get; set; } = default!;
    public DbSet<Academy.Models.Group> Groups { get; set; } = default!;
    public DbSet<Academy.Models.Student> Students { get; set; } = default!;
    public DbSet<Academy.Models.Teacher> Teachers { get; set; } = default!;
    public DbSet<Academy.Models.Discipline> Disciplines { get; set; } = default!;
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //DbSet для таблицы связи "многие-ко-многим" (преподаватель-дисциплина).
    //DbSet «շատ-շատ» կապի աղյուսակի համար (դասախոս-դիսցիպլին)։
    public DbSet<TeachersDisciplinesRelation> TeachersDisciplinesRelation { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //Составной первичный ключ (teacher + discipline).
        //  Это нужно, потому что в таблице нет отдельного ID,
        //  а пара teacher+discipline уникальна.
        //Բաղադրյալ առաջնային բանալի (teacher + discipline)։
        //  Դա անհրաժեշտ է, քանի որ աղյուսակում առանձին ID չկա,
        //  իսկ teacher+discipline զույգը եզակի է։

        modelBuilder.Entity<TeachersDisciplinesRelation>()
            .HasKey(tdr => new { tdr.teacher, tdr.discipline });
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

}
