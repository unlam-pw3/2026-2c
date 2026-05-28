using Clase6.EF.Entidades;

namespace Clase6.EF.Logica;

public interface IFabricantesLogica
{
    List<Fabricante> ObtenerTodos();
    Fabricante? ObtenerPorId(int id);
}
public class FabricantesLogica : IFabricantesLogica
{
    private JugueteriaDbContext db;
    public FabricantesLogica(JugueteriaDbContext db)
    {
        this.db = db;
    }
    public List<Fabricante> ObtenerTodos()
    {
        return db.Fabricantes
            .OrderBy(c => c.Nombre)
            .ToList();
    }
    public Fabricante? ObtenerPorId(int id)
    {
        return db.Fabricantes.Find(id);
    }
}


