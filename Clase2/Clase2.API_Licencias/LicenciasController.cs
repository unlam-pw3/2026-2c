using Clase2.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.API_Licencias
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenciasController : ControllerBase
    {
        ILicenciaService _LicenciaServicio;

        public LicenciasController(ILicenciaService licenciaService)
        {
            _LicenciaServicio = licenciaService;
        }

        [HttpPost]
        public IActionResult RegistrarLicencia(Entidad.Licencia licencia)
        {
            _LicenciaServicio.RegistrarLicencia(licencia);
            return Ok();
        }

        [HttpGet]
        public IActionResult ObtenerLicencias()
        {
            var licencias = _LicenciaServicio.ObtenerLicencias();
            return Ok(licencias);
        }
    }
}
