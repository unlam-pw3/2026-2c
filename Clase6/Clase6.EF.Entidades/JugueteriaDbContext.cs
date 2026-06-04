namespace Clase6.EF.Entidades;


using Microsoft.EntityFrameworkCore;

public class JugueteriaDbContext : DbContext
{
    public DbSet<Juguete> Juguetes { get; set; }
    public DbSet<Fabricante> Fabricantes { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Sucursal> Sucursales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=.;Database=Clase6JugueteriaDb;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Fabricante>().HasData(
            new Fabricante { Id = 1, Nombre = "LEGO", Pais = "Dinamarca" },
            new Fabricante { Id = 2, Nombre = "Hasbro", Pais = "Estados Unidos" },
            new Fabricante { Id = 3, Nombre = "Mattel", Pais = "Estados Unidos" }
        );

        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, Nombre = "Construcción" },
            new Categoria { Id = 2, Nombre = "Acción" },
            new Categoria { Id = 3, Nombre = "Muñecas" }
        );

        // Agregar esto:
        modelBuilder.Entity<Sucursal>().HasData(
            new Sucursal { Id = 1, Nombre = "Sucursal Centro", Calle = "Corrientes", Altura = "1234" },
            new Sucursal { Id = 2, Nombre = "Sucursal Palermo", Calle = "Santa Fe", Altura = "4567" },
            new Sucursal { Id = 3, Nombre = "Sucursal Belgrano", Calle = "Cabildo", Altura = "890" }
        );
    }
}