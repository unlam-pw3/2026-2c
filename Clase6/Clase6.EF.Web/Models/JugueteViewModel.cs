using Clase6.EF.Entidades;

namespace Clase6.EF.Web.Models;

public class JugueteViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int EdadRecomendada { get; set; }

    public int FabricanteId { get; set; }
    public List<int> CategoriaIds { get; set; } = new();

    public Juguete ToEntity()
    {
        return new Juguete
        {
            Id = this.Id,
            Nombre = this.Nombre,
            Precio = this.Precio,
            EdadRecomendada = this.EdadRecomendada,
            FabricanteId = this.FabricanteId
        };
    }

    public static JugueteViewModel FromEntity(Juguete juguete)
    {
        return new JugueteViewModel
        {
            Id = juguete.Id,
            Nombre = juguete.Nombre,
            Precio = juguete.Precio,
            EdadRecomendada = juguete.EdadRecomendada,
            FabricanteId = juguete.FabricanteId ?? 0,
            CategoriaIds = juguete.Categorias.Select(c => c.Id).ToList()
        };
    }
}
