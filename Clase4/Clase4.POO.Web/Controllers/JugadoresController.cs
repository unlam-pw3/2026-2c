using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Clase4.POO.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers;

public class JugadoresController : Controller
{
    private readonly IJugadoresLogica _jugadoresLogica;
    private readonly IPersonajesLogica _personajesLogica;

    public JugadoresController(IJugadoresLogica jugadoresLogica, IPersonajesLogica personajesLogica)
    {
        _jugadoresLogica = jugadoresLogica;
        _personajesLogica = personajesLogica;
    }

    [HttpGet]
    public IActionResult Agregar()
    {
        ViewBag.Personajes = _personajesLogica.ObtenerPersonajes();
        return View();
    }

    [HttpPost]
    public IActionResult Agregar(JugadorViewModel jugadorViewModel)
    {
        var jugador = new Jugador
        {
            Nombre = jugadorViewModel.Nombre,
            PersonajeElegido = _personajesLogica.ObtenerPersonajePorId(jugadorViewModel.IdPersonajeElegido)
        };

        _jugadoresLogica.AgregarJugador(jugador);
        return RedirectToAction("Lista");
    }

    [HttpGet]
    public IActionResult Lista()
    {
        var jugadores = _jugadoresLogica.ObtenerJugadores();
        return View(jugadores);
    }
}
