using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public interface IPartidasLogica
{
    public List<Partida> ObtenerPartidas();
    public void AgregarPartida(Partida partida);
    public Partida ObtenerPartida(Guid id);
    void EliminarPartida(Partida partida);
}

public class PartidasLogica : IPartidasLogica
{
    private static List<Partida> _lista = new List<Partida>();

    public List<Partida> ObtenerPartidas()
    {
        return _lista;
    }

    public void AgregarPartida(Partida partida)
    {
        if (partida == null)
            return;

        partida.Id = Guid.NewGuid();
        partida.Estado = "Sin comenzar";

        _lista.Add(partida);
    }

    public Partida ObtenerPartida(Guid id)
    {
        return _lista.FirstOrDefault(p => p.Id == id);
    }

    public void EliminarPartida(Partida partida)
    {
        if (partida == null)
            return;
        _lista.Remove(partida);
    }

}

