using Clase6.EF.Entidades;
using Clase6.EF.Logica;
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
            var juguetes = juguetesLogica.ObtenerJuguetes();
            return View(juguetes);
        }
    }
}
