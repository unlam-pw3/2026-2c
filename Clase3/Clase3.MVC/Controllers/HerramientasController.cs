using Clase3.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.Controllers
{
    public class HerramientasController : Controller
    {
        private IHerramientaServicio _herramientaServicio;
        public HerramientasController(IHerramientaServicio herramientaServicio)
        {
            _herramientaServicio = herramientaServicio;
        }
        public IActionResult Index()
        {
            return View(_herramientaServicio.ObtenerHerramientas());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Entidad.Herramienta herramienta)
        {
            _herramientaServicio.AgregarHerramienta(herramienta);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _herramientaServicio.EliminarHerramienta(id);
            return RedirectToAction("Index");
        }
    }
}
