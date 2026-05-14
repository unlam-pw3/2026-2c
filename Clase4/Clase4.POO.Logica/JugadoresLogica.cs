using Clase4.POO.Entidades;
using Clase4.POO.Entidades.Personajes;

namespace Clase4.POO.Logica;

public interface IJugadoresLogica
{
    public List<Jugador> ObtenerJugadores();
    public void AgregarJugador(Jugador jugador);
    public Jugador ObtenerJugador(int id);
    void EliminarJugador(Jugador jugador);
}

public class JugadoresLogica : IJugadoresLogica
{
    private static List<Jugador> _lista = new List<Jugador>()
    {
            new Jugador() { Id = 1, Nombre = "Legolas", PersonajeElegido = new Elfo() { Id = 1} },
            new Jugador() { Id = 2, Nombre = "Gandalf", PersonajeElegido = new Hechicero() { Id = 2} },
    };

    public List<Jugador> ObtenerJugadores()
    {
        return _lista;
    }

    public void AgregarJugador(Jugador jugador)
    {
        if (jugador == null)
            return;

        int proximoId = _lista.Count > 0 ? _lista.Max(p => p.Id) + 1 : 1;
        jugador.Id = proximoId;

        _lista.Add(jugador);
    }

    public Jugador ObtenerJugador(int id)
    {
        return _lista.FirstOrDefault(p => p.Id == id);
    }

    public void EliminarJugador(Jugador jugador)
    {
        if (jugador == null)
            return;
        _lista.Remove(jugador);
    }
}
