using Clase4.POO.Entidades;

namespace Clase4.POO.Web.Models;

public class PartidaViewModel
{
    public Guid Id { get; set; }
    public int IdJugador1 { get; set; }
    public int? IdJugador2 { get; set; }
    public string Estado { get; set; } = "Sin comenzar";
    public int TurnoActual { get; set; }
    public int MaximoTurnos { get; set; }
    public JugadorViewModel Jugador1 { get; set; }
    public JugadorViewModel Jugador2 { get; set; }
    public JugadorViewModel Ganador { get; set; }

    public PartidaViewModel()
    {
    }

    public PartidaViewModel(Partida partida)
    {
        Id = partida.Id;
        IdJugador1 = partida.Jugador1.Id;
        IdJugador2 = partida.Jugador2?.Id;
        Estado = partida.Estado;
        TurnoActual = partida.TurnoActual;
        MaximoTurnos = partida.MaximoTurnos;
        Jugador1 = new JugadorViewModel(partida.Jugador1);
        if (partida.Jugador2 != null)
        {
            Jugador2 = new JugadorViewModel(partida.Jugador2);
        }
        if (partida.Ganador != null)
        {
            Ganador = new JugadorViewModel(partida.Ganador);
        }
    }

}
