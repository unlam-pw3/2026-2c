using Clase4.POO.Entidades;
using Clase4.POO.Entidades.Personajes;
using Clase4.POO.Logica;
using Clase4.POO.Web.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers;

public class PartidasController : Controller
{
    private readonly IJugadoresLogica _jugadoresLogica;
    private readonly IPartidasLogica _partidasLogica;

    public PartidasController(IJugadoresLogica jugadoresLogica, IPartidasLogica partidasLogica)
    {
        _jugadoresLogica = jugadoresLogica;
        _partidasLogica = partidasLogica;
    }

    [HttpGet]
    public IActionResult Crear()
    {
        var jugadores = _jugadoresLogica.ObtenerJugadores();
        var jugadoresViewModel = new List<JugadorViewModel>();

        foreach (var jugador in jugadores)
        {
            jugadoresViewModel.Add(new JugadorViewModel(jugador));
        }
        ViewBag.Jugadores = jugadoresViewModel;
        return View();
    }

    [HttpPost]
    public IActionResult Crear(int idJugador1)
    {
        var jugador1 = _jugadoresLogica.ObtenerJugador(idJugador1);

        if (jugador1 == null)
        {
            return RedirectToAction("Crear");
        }

        var partida = new Partida(jugador1);

        _partidasLogica.AgregarPartida(partida);
        return RedirectToAction("Lista");
    }

    public IActionResult Lista()
    {
        var partidas = _partidasLogica.ObtenerPartidas();
        var partidasViewModel = new List<PartidaViewModel>();
        foreach (var partida in partidas)
        {
            partidasViewModel.Add(new PartidaViewModel(partida));
        }
                
        return View(partidasViewModel);
    }

    [HttpGet]
    public IActionResult Detalle(Guid id)
    {
        var partida = _partidasLogica.ObtenerPartida(id);
        if (partida == null)
        {
            return RedirectToAction("Lista");
        }
        ViewBag.Jugadores = _jugadoresLogica.ObtenerJugadores();
        return View(new PartidaViewModel(partida));
    }

    [HttpGet]
    public IActionResult Unirme(Guid id)
    {
        var partida = _partidasLogica.ObtenerPartida(id);
        if (partida == null || partida.Jugador2 != null)
        {
            return RedirectToAction("Lista");
        }
        ViewBag.Jugadores = _jugadoresLogica.ObtenerJugadores();

        return View(partida);
    }

    [HttpPost]
    public IActionResult Unirme(Guid id, int idJugador)
    {
        var partida = _partidasLogica.ObtenerPartida(id);
        var jugador = _jugadoresLogica.ObtenerJugador(idJugador);

        if (partida == null || jugador == null || partida.Jugador2 != null)
        {
            return RedirectToAction("Lista");
        }

        partida.Jugador2 = jugador;
        partida.Estado = "En progreso";
        TempData["IdTurnoJugador"] = partida.Jugador1.Id;
        return RedirectToAction("Batalla", new { id = partida.Id });
    }

    [HttpGet]
    public IActionResult Batalla(Guid id)
    {
        var partida = _partidasLogica.ObtenerPartida(id);
        if (partida == null || partida.Jugador2 == null)
        {
            return RedirectToAction("Lista");
        }
        BatallaViewModel batalla = new BatallaViewModel
        {
            Id = id,
            Partida = new PartidaViewModel(partida),
            IdTurnoJugador = partida.Jugador1.Id,
            Jugador1PuedeUsarHabilidad = true,
        };

        return View(batalla);
    }
    [HttpPost]
    public IActionResult Batalla(BatallaViewModel batalla)
    {
        var partida = _partidasLogica.ObtenerPartida(batalla.Id);

        switch (Request.Form["accion"])
        {
            case "EjecutarHabilidadJug1":
                partida.Jugador1.PersonajeElegido.EjecutarHabilidad(batalla.IdJugador1HabilidadSeleccionada, partida.Jugador2.PersonajeElegido);
                batalla.IdTurnoJugador = partida.Jugador1.Id;
                batalla.Jugador1PuedeUsarHabilidad = false;
                break;
            case "EjecutarAtaqueBasicoJug1":
                partida.Jugador1.PersonajeElegido.EjecutarAtaqueBasico(partida.Jugador2.PersonajeElegido);
                
                batalla.IdTurnoJugador = partida.Jugador2.Id;
                partida.Jugador1.PersonajeElegido.DisminuirEnfriamientos();
                batalla.Jugador2PuedeUsarHabilidad = true;
                break;

            case "EjecutarHabilidadJug2":
                if(batalla.IdJugador2HabilidadSeleccionada == null)
                    return RedirectToAction("Batalla", new { id = batalla.Id });

                batalla.IdTurnoJugador = partida.Jugador2.Id;
                partida.Jugador2.PersonajeElegido.EjecutarHabilidad(batalla.IdJugador2HabilidadSeleccionada.Value, partida.Jugador1.PersonajeElegido);
                batalla.Jugador2PuedeUsarHabilidad = false;
                break;
            case "EjecutarAtaqueBasicoJug2":
                partida.Jugador2.PersonajeElegido.EjecutarAtaqueBasico(partida.Jugador1.PersonajeElegido);
                batalla.IdTurnoJugador = partida.Jugador1.Id;
                partida.Jugador2.PersonajeElegido.DisminuirEnfriamientos();
                batalla.Jugador1PuedeUsarHabilidad = true;
                break;
        }

        batalla.Partida = new PartidaViewModel(partida);

        return View(batalla);
    }


}