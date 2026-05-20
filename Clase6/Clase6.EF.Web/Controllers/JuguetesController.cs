using Clase6.EF.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF.Web.Controllers
{
    public class JuguetesController : Controller
    {
        public IActionResult Index()
        {
            var db = new JugueteriaDbContext();
            var juguetes = db.Juguetes.ToList();
            return View(juguetes);
        }
    }
}
