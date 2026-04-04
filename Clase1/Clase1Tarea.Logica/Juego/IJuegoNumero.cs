using System.Collections.Generic;

namespace Clase1Tarea.Logica.Juego
{
    public interface IJuegoNumero
    {
        int IntentosRestantes { get; }
        bool IsGanado { get; }
        bool IsPerdido { get; }
        string Adivinar(int numero);
    }
}