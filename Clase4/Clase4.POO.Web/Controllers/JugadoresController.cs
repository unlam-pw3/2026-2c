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

    [HttpGet]
    public IActionResult Eliminar(int id)
    {
        var jugador = _jugadoresLogica.ObtenerJugador(id);
        if (jugador != null)
        {
            _jugadoresLogica.EliminarJugador(jugador);
        }
        return RedirectToAction("Lista");
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var jugador = _jugadoresLogica.ObtenerJugador(id);
        if (jugador == null)
        {
            return NotFound();
        }

        var jugadorViewModel = new JugadorViewModel
        {
            Id = jugador.Id,
            Nombre = jugador.Nombre,
            IdPersonajeElegido = jugador.PersonajeElegido?.Id ?? 0
        };
        ViewBag.Personajes = _personajesLogica.ObtenerPersonajes();
        return View(jugadorViewModel);
    }

    [HttpPost]
    public IActionResult Editar(JugadorViewModel jugadorViewModel)
    {
        var jugador = _jugadoresLogica.ObtenerJugador(jugadorViewModel.Id);
        if (jugador == null)
        {
            return NotFound();
        }

        jugador.Nombre = jugadorViewModel.Nombre;
        jugador.PersonajeElegido = _personajesLogica.ObtenerPersonajePorId(jugadorViewModel.IdPersonajeElegido);
        return RedirectToAction("Lista");
    }
}
