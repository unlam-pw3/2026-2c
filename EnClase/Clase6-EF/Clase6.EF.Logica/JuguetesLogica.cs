
using Clase6.EF.Entidades;
using Clase6.EF.Logica.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Clase6.EF.Logica;
public interface IJuguetesLogica
{
    void Actualizar(Juguete juguete);
    void Agregar(Juguete juguete);
    void Eliminar(int id);
    List<Juguete> Obtener();
    (IEnumerable<Juguete> items, int totalCount) ObtenerPaginado(int page, int pageSize);
    public Juguete? ObtenerPorId(int id);
    (IReadOnlyList<Juguete> items, int totalCount) Buscar(JugueteFiltro f);
}

public class JuguetesLogica : IJuguetesLogica
{
    private readonly JugueteriaDbContext db;
    public JuguetesLogica(JugueteriaDbContext db)
    {
        this.db = db;
    }
    public List<Juguete> Obtener()
    {
        return db.Juguetes.Include(j => j.Tematica).ToList();
    }

    public Juguete? ObtenerPorId(int id)
    {
        return db.Juguetes.Include(j=> j.Sucursales).FirstOrDefault(j => j.Id == id);
    }

    public void Agregar(Juguete juguete)
    {
        db.Juguetes.Add(juguete);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var juguete = Obtener()
            .FirstOrDefault(j => j.Id == id);
        if (juguete == null)
            return;

        db.Juguetes.Remove(juguete);
        db.SaveChanges();
    }
    public void Actualizar(Juguete juguete)
    {
        db.SaveChanges();
    }

    public (IEnumerable<Juguete> items, int totalCount) ObtenerPaginado(int page, int pageSize)
    {
        db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        
        var items = db.Juguetes
            .Include(j => j.Tematica)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        var totalCount = db.Juguetes.Count();
        return (items, totalCount);
    }

    // implementación:
    public (IReadOnlyList<Juguete> items, int totalCount) Buscar(JugueteFiltro f)
    {
        var page = f.Page < 1 ? 1 : f.Page;
        var size = f.PageSize < 1 ? 10 : Math.Min(f.PageSize, 100);

        var q = db.Juguetes.AsNoTracking().Include(x => x.Tematica).AsQueryable();

        if (!string.IsNullOrWhiteSpace(f.Nombre))
            q = q.Where(x => x.Nombre.Contains(f.Nombre));

        if (f.TematicaId.HasValue)
            q = q.Where(x => x.TematicaId == f.TematicaId.Value);

        if (f.PrecioMin.HasValue)
            q = q.Where(x => x.Precio >= f.PrecioMin.Value);

        if (f.PrecioMax.HasValue)
            q = q.Where(x => x.Precio <= f.PrecioMax.Value);

        q = (f.SortBy?.ToLower(), f.SortDir?.ToLower()) switch
        {
            ("nombre", "desc") => q.OrderByDescending(x => x.Nombre),
            ("nombre", _) => q.OrderBy(x => x.Nombre),
            ("precio", "desc") => q.OrderByDescending(x => x.Precio),
            ("precio", _) => q.OrderBy(x => x.Precio),
            ("edad", "desc") => q.OrderByDescending(x => x.EdadRecomendada),
            ("edad", _) => q.OrderBy(x => x.EdadRecomendada),
            ("id", "desc") => q.OrderByDescending(x => x.Id),
            _ => q.OrderBy(x => x.Id)
        };

        var total = q.Count();
        var items = q.Skip((page - 1) * size).Take(size).ToList();

        return (items, total);
    }
}
