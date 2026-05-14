using Clase4.POO.Entidades;

namespace Clase4.POO.Web.Models;

public class BatallaViewModel
{
    public Guid Id { get; set; }
    public PartidaViewModel? Partida { get; set; }
    public Guid IdJugador1HabilidadSeleccionada { get; set; }
    public Guid? IdJugador2HabilidadSeleccionada { get; set; }
    public int IdTurnoJugador { get; set; }
    public bool Jugador1PuedeUsarHabilidad { get; set; }
    public bool Jugador2PuedeUsarHabilidad { get; set; }

    public BatallaViewModel()
    {
        Partida = new PartidaViewModel()
        {
            Id = Id
        };
    }
}
