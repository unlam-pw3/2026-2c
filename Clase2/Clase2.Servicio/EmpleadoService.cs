namespace Clase2.Servicio
{
    public interface IEmpleadoService
    {
        void RegistrarEmpleado(Entidad.Empleado empleado);
        List<Entidad.Empleado> ObtenerEmpleados();
    }

    public class EmpleadoService : IEmpleadoService
    {
        private List<Entidad.Empleado> empleados;

        public EmpleadoService( )
        {
            empleados = new List<Entidad.Empleado>();
        }

        public void RegistrarEmpleado(Entidad.Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Entidad.Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

    }
}
