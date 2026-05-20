
using Clase6.EF.Entidades;

namespace Clase6.EF.Logica;
public interface IJuguetesLogica
{
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
}
