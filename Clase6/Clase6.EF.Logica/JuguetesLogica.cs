
using Clase6.EF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Clase6.EF.Logica;
public interface IJuguetesLogica
{
    void Actualizar(Juguete juguete);
    void Agregar(Juguete juguete);
    void Eliminar(int id);
    List<Juguete> Obtener(bool incluirCategorias = false);
    List<Juguete> ObtenerPorFabricanteId(int value);
    public Juguete? ObtenerPorId(int id);
}

public class JuguetesLogica : IJuguetesLogica
{
    private readonly JugueteriaDbContext db;
    public JuguetesLogica(JugueteriaDbContext db)
    {
        this.db = db;
    }
    public List<Juguete> Obtener(bool incluirCategorias = false)
    {
        if (incluirCategorias)
        {
        return db.Juguetes.Include(j => j.Categorias).Include(j => j.Sucursal).ToList();
        }

        return db.Juguetes.Include(j => j.Sucursal).ToList();

    }

    public Juguete? ObtenerPorId(int id)
    {
        return db.Juguetes
            .Include(j => j.Categorias)
            .Include(j => j.Sucursal)
            .FirstOrDefault(j => j.Id == id);
    }

    public void Agregar(Juguete juguete)
    {
        db.Juguetes.Add(juguete);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var juguete = ObtenerPorId(id);

        if (juguete == null)
            return;

        db.Juguetes.Remove(juguete);
        db.SaveChanges();
    }
    public void Actualizar(Juguete juguete)
    {
        db.SaveChanges();
    }

    public List<Juguete> ObtenerPorFabricanteId(int fabricanteId)
    {
        return db.Juguetes
            .Include(j => j.Categorias)
            .Include(j => j.Sucursal)
            .Where(j => j.FabricanteId == fabricanteId)
            .ToList();
    }

    //obtener juguetes por categoria
    // public List<Juguete> ObtenerPorCategoriaId(int categoriaId)
    //{
    //    return db.Juguetes
    //        .Include(j => j.Categorias)
    //        .Where(j => j.Categorias.Any(c => c.Id == categoriaId))
    //        .ToList();
    //}
}
