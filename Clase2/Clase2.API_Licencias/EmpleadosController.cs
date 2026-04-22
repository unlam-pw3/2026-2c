using Clase2.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.API_Licencias
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        IEmpleadoService _EmpleadoServicio;

        public EmpleadosController(IEmpleadoService empleadoService)
        {   
            _EmpleadoServicio = empleadoService;
        }

        [HttpPost]
        public IActionResult REmpleado(Entidad.Empleado empleado)
        {
            _EmpleadoServicio.RegistrarEmpleado(empleado);
            return Ok();
        }

        [HttpGet]
        public IActionResult OEmpleado()
        {
            var empleados = _EmpleadoServicio.ObtenerEmpleados();
            return Ok(empleados);
        }


    }
}
