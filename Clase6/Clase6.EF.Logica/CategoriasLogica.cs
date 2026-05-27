using Clase6.EF.Entidades;

namespace Clase6.EF.Logica;

public interface ICategoriasLogica
{
    List<Categoria> ObtenerTodos();
    Categoria? ObtenerPorId(int id);
    List<Categoria> ObtenerPorIds(List<int> categoriaIds);
}
public class CategoriasLogica : ICategoriasLogica
{
    private JugueteriaDbContext db;
    public CategoriasLogica(JugueteriaDbContext db)
    {
        this.db = db;
    }
    public List<Categoria> ObtenerTodos()
    {
        return db.Categorias
            .OrderBy(c => c.Nombre)
            .ToList();
    }
    public Categoria? ObtenerPorId(int id)
    {
        return db.Categorias.Find(id);
    }

    public List<Categoria> ObtenerPorIds(List<int> categoriaIds)
    {
        return db.Categorias
            .Where(c => categoriaIds.Contains(c.Id))
            .ToList();
    }
}
