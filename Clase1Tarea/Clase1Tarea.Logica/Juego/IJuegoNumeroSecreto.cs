using System.Collections.Generic;

namespace Clase1Tarea.Logica.Juego;

public interface IJuegoNumeroSecreto
{
    int NumeroSecreto { get; }
    IReadOnlyCollection<int> NumerosAdivinados { get; }
    int CantidadIntentos { get; }
    bool ElNumeroFueAdivinado { get; }
    bool Adivinar(int numero);
}