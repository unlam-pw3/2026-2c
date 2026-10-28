namespace Clase6.EF.Entidades;


using Microsoft.EntityFrameworkCore;

public class JugueteriaDbContext : DbContext
{
    public JugueteriaDbContext(DbContextOptions<JugueteriaDbContext> options)
       : base(options)
    {
    }

    public DbSet<Juguete> Juguetes { get; set; }
    public DbSet<Tematica> Tematicas { get; set; }
    public DbSet<TematicaLibro> TematicasLibro { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Pagina> Paginas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
            @"Server=.;Database=2026-2c-Jugueteria;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
