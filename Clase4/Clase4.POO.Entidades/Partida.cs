namespace Clase4.POO.Entidades;

public class Partida
{
    public Guid Id { get; set; }
    public Jugador Jugador1 { get; set; }
    public Jugador? Jugador2 { get; set; }
    public string Estado { get; set; }
    public Jugador Ganador { get; set; }
    public Partida(Jugador jugador1)
    {
        Jugador1 = jugador1;
    }

    public int TurnoActual { get; set; } = 0;
    public int MaximoTurnos { get; set; } = 50;
}