using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Clase6.EF.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF.Web.Controllers
{
    public class JuguetesController : Controller
    {
        private readonly IJuguetesLogica juguetesLogica;

        public JuguetesController(IJuguetesLogica juguetesLogica)
        {
            this.juguetesLogica = juguetesLogica;
        }

        public IActionResult Index()
        {
            var juguetes = juguetesLogica.Obtener();
            return View(juguetes);
        }

        //Agregar
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(JugueteViewModel jugueteVM)
        {
            if (!ModelState.IsValid)
                return View(jugueteVM);

            juguetesLogica.Agregar(jugueteVM.ToEntity());
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            juguetesLogica.Eliminar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var juguete = juguetesLogica.ObtenerPorId(id);

            if (juguete == null)
                return NotFound();

            return View(JugueteViewModel.FromEntity(juguete));
        }

        [HttpPost]
        public IActionResult Editar(JugueteViewModel jugueteVM)
        {
            if (!ModelState.IsValid)
                return View(jugueteVM);

            var juguete = juguetesLogica.ObtenerPorId(jugueteVM.Id);
            if (juguete == null)
                return NotFound();

            juguete.Nombre = jugueteVM.Nombre;
            juguete.Precio = jugueteVM.Precio;
            juguete.EdadRecomendada = jugueteVM.EdadRecomendada;

            juguetesLogica.Actualizar(juguete);
            return RedirectToAction("Index");
        }
    }
}
