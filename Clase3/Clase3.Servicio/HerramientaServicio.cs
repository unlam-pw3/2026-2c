using Clase3.Entidad;

namespace Clase3.Servicio
{
    public interface IHerramientaServicio
    {
        List<Entidad.Herramienta> ObtenerHerramientas();
        void AgregarHerramienta(Entidad.Herramienta herramienta);
        Herramienta BuscarHerramientaPorId(int id);
        void EliminarHerramienta(int id);
        void EditarHerramienta(Entidad.Herramienta herramienta);
    }   

    public class HerramientaServicio : IHerramientaServicio
    {
        private static List<Entidad.Herramienta> herramientas {  get; set; }
        private int contadorId = 3; 
        public HerramientaServicio()
        {
            herramientas = new List<Entidad.Herramienta>();
            herramientas.Add(new Entidad.Herramienta { Id = 1, Descripcion = "Martillo", Precio = 10.5m, Imagen = "\\imagenes\\martillo.jpg" });
            herramientas.Add(new Entidad.Herramienta { Id = 2, Descripcion = "Destornillador", Precio = 5.0m, Imagen = "\\imagenes\\destornillador.jpg" });
        }

        public List<Entidad.Herramienta> ObtenerHerramientas()
        {
            return herramientas;
        }
        public void AgregarHerramienta(Entidad.Herramienta herramienta)
            {
             herramienta.Id = contadorId++;
                
             if (herramienta.Imagen == null)
             {
             herramienta.Imagen = "\\imagenes\\sinimagen.jpg";
            } else             {
                herramienta.Imagen = "\\imagenes\\" + herramienta.Imagen + ".jpg";
            }

            herramientas.Add(herramienta);
            }
        public Herramienta BuscarHerramientaPorId(int id)
        {
            var herramienta = herramientas.FirstOrDefault(h => h.Id == id);
            return herramienta;
        }

        public void EliminarHerramienta(int id)
        {
            var herramienta = BuscarHerramientaPorId(id);
            if (herramienta != null)
            {
                herramientas.Remove(herramienta);
            }
        }
        public void EditarHerramienta(Herramienta herramienta)
        {
            var herramientaExistente = BuscarHerramientaPorId(herramienta.Id);
            if (herramientaExistente != null)
            {
                if (herramienta.Descripcion != null)
                {
                    herramientaExistente.Descripcion = herramienta.Descripcion;
                }
                if (herramienta.Precio != 0)
                {
                    herramientaExistente.Precio = herramienta.Precio;
                }
                if (herramienta.Imagen != null && herramienta.Imagen != "")
                {
                    herramientaExistente.Imagen = "\\imagenes\\" + herramienta.Imagen + ".jpg";
                }
            }
        
        }
    }
}
