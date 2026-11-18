using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; } // el get; set; hace automaticamente el getter y el setter

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Npgsql (timestamp with time zone) solo acepta DateTime con Kind=Utc.
        // Al guardar: si no es Utc se marca como Utc. Al leer: siempre Utc.
        modelBuilder.Entity<Event>()
            .Property(e => e.Date)
            .HasConversion(
                v => v.Kind == DateTimeKind.Utc ? v : DateTime.SpecifyKind(v, DateTimeKind.Utc),
                v => DateTime.SpecifyKind(v, DateTimeKind.Utc));
    }
}
