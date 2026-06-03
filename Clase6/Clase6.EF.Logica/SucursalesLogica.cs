using Clase6.EF.Entidades;

namespace Clase6.EF.Logica
{
    public interface ISucursalesLogica
    {
        List<Sucursal> ObtenerTodos();
        Sucursal? ObtenerPorId(int id);
    }
    public class SucursalesLogica : ISucursalesLogica
    {
        private JugueteriaDbContext db;
        public SucursalesLogica(JugueteriaDbContext db)
        {
            this.db = db;
        }
        public List<Sucursal> ObtenerTodos()
        {
            return db.Sucursales
                .OrderBy(c => c.Nombre)
                .ToList();
        }
        public Sucursal? ObtenerPorId(int id)
        {
            return db.Sucursales.Find(id);
        }
    }
}
