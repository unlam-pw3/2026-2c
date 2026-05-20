
using Clase6.EF.Entidades;

namespace Clase6.EF.Logica;
public interface IJuguetesLogica
{
    void AgregarJuguete(Juguete juguete);
    List<Juguete> ObtenerJuguetes();
}

public class JuguetesLogica : IJuguetesLogica
{
    private readonly JugueteriaDbContext db;
    public JuguetesLogica(JugueteriaDbContext db)
    {
        this.db = db;
    }
    public List<Juguete> ObtenerJuguetes()
    {
        return db.Juguetes.ToList();
    }
    public void AgregarJuguete(Juguete juguete)
    {
        db.Juguetes.Add(juguete);
        db.SaveChanges();
    }
}
