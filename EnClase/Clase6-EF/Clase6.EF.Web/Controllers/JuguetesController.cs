using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Clase6.EF.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF.Web.Controllers
{
    public class JuguetesController : Controller
    {
        private readonly IJuguetesLogica juguetesLogica;
        private readonly ITematicaLogica tematicaLogica;

        public JuguetesController(IJuguetesLogica juguetesLogica, ITematicaLogica tematicaLogica)
        {
            this.juguetesLogica = juguetesLogica;
            this.tematicaLogica = tematicaLogica;
        }

        public IActionResult Index()
        {
            var juguetes = juguetesLogica.Obtener();
            var juguetesVM = juguetes.Select(j => JugueteViewModel.FromEntity(j)).ToList();

            return View(juguetesVM);
        }

        //Agregar
        public IActionResult Agregar()
        {
            var jugueteVM = new JugueteViewModel();
            jugueteVM.Tematicas = tematicaLogica.Obtener();

            return View(jugueteVM);
        }

        [HttpPost]
        public IActionResult Agregar(JugueteViewModel jugueteVM)
        {
            if (!ModelState.IsValid)
            {
                jugueteVM.Tematicas = tematicaLogica.Obtener();
                return View(jugueteVM);
            }

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

            var jugueteVM = JugueteViewModel.FromEntity(juguete);
            jugueteVM.Tematicas = tematicaLogica.Obtener();

            return View(jugueteVM);
        }

        [HttpPost]
        public IActionResult Editar(JugueteViewModel jugueteVM)
        {
            if (!ModelState.IsValid)
            {
                jugueteVM.Tematicas = tematicaLogica.Obtener();
                return View(jugueteVM);
            }

            var juguete = juguetesLogica.ObtenerPorId(jugueteVM.Id);
            if (juguete == null)
                return NotFound();

            juguete.Nombre = jugueteVM.Nombre;
            juguete.Precio = jugueteVM.Precio;
            juguete.EdadRecomendada = jugueteVM.EdadRecomendada;
            juguete.TematicaId = jugueteVM.TematicaId;

            juguetesLogica.Actualizar(juguete);
            return RedirectToAction("Index");
        }
    }
}
