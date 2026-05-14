using Clase4.POO.Entidades;

namespace Clase4.POO.Web.Models;

public class JugadorViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public int IdPersonajeElegido { get; set; }
    public Personaje PersonajeElegido { get; set; }

    public JugadorViewModel()
    {
    }

    public JugadorViewModel(Jugador jugador)
    {
        Id = jugador.Id;
        Nombre = jugador.Nombre;
        IdPersonajeElegido = jugador.PersonajeElegido?.Id ?? 0;
        PersonajeElegido = jugador.PersonajeElegido;
    }
}
