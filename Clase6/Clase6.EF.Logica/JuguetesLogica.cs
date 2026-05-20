
using Clase6.EF.Entidades;

namespace Clase6.EF.Logica;
public interface IJuguetesLogica
{
    void Agregar(Juguete juguete);
    void Eliminar(int id);
    List<Juguete> Obtener();
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
        return db.Juguetes.ToList();
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
}
