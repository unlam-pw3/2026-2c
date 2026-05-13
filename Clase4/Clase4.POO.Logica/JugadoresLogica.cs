using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public interface IJugadoresLogica
{
    public List<Jugador> ObtenerJugadores();
    public void AgregarJugador(Jugador jugador);
    public Jugador ObtenerJugador(int id);
}

public class JugadoresLogica : IJugadoresLogica
{
    private static List<Jugador> _lista = new List<Jugador>();

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
}
