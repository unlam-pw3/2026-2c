namespace Clase6.EF.Entidades;


using Microsoft.EntityFrameworkCore;

public class JugueteriaDbContext : DbContext
{
    public DbSet<Juguete> Juguetes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=Clase6JugueteriaDb;Trusted_Connection=True;TrustServerCertificate=True");
    }
}