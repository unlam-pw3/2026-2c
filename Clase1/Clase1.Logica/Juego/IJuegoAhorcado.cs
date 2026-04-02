using System.Collections.Generic;

namespace Clase1.Logica.Juego
{
    public interface IJuegoAhorcado
    {
        string PalabraEnmascarada { get; }
        int IntentosRestantes { get; }
        IReadOnlyCollection<char> LetrasAdivinadas { get; }
        bool IsGanado { get; }
        bool IsPerdido { get; }
        bool Adivinar(char letra);
    }
}