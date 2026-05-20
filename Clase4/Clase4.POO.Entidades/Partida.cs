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

    public void CompletarTurno(Jugador jug)
    {        
        TurnoActual++;

        if (TurnoActual > MaximoTurnos)
        {
            Estado = "Finalizada";

            if (Jugador1.PersonajeElegido.HpActual > Jugador2.PersonajeElegido.HpActual)
            {
                Ganador = Jugador1;
            }
            else if (Jugador2.PersonajeElegido.HpActual > Jugador1.PersonajeElegido.HpActual)
            {
                Ganador = Jugador2;
            }
            else
            {
                Ganador = null;
            }
        }
    }
}