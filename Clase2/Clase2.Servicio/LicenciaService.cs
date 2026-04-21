namespace Clase2.Servicio
{
    public interface ILicenciaService
    {
        void RegistrarLicencia(Entidad.Licencia licencia);
        List<Entidad.Licencia> ObtenerLicencias();
    }

    public class LicenciaService : ILicenciaService
    {
        private List<Entidad.Licencia> licencias;

        public LicenciaService()
        {
            licencias = new List<Entidad.Licencia>();
        }

        public void RegistrarLicencia(Entidad.Licencia licencia)
        {
            licencias.Add(licencia);
        }

        public List<Entidad.Licencia> ObtenerLicencias()
        {
            return licencias;
        }

    }
}
