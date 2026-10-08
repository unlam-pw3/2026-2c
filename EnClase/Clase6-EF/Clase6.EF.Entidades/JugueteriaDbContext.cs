namespace Clase6.EF.Entidades;


using Microsoft.EntityFrameworkCore;

public class JugueteriaDbContext : DbContext
{
    public DbSet<Juguete> Juguetes { get; set; }
    public DbSet<Tematica> Tematicas { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=2026-2c-Jugueteria;Trusted_Connection=True;TrustServerCertificate=True");
    }
}