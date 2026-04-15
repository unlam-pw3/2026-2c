using System;

namespace Clase1.Logica.Numero;

public class JuegoNumero : IJuegoNumero
{
    private readonly int _min;
    private readonly int _max;

    public int Secreto { get; private set; }
    public int IntentosMaximos { get; }
    public int IntentosRestantes { get; private set; }
    public int IntentoActual { get; private set; }
    public bool IsGanado { get; private set; }
    public bool IsPerdido { get; private set; }

    public JuegoNumero(int secreto, int intentosMaximos = 6, int min = 1, int max = 100)
    {
        if (min >= max) throw new ArgumentException("min debe ser menor que max");
        if (secreto < min || secreto > max) throw new ArgumentOutOfRangeException(nameof(secreto));

        Secreto = secreto;
        IntentosMaximos = intentosMaximos > 0 ? intentosMaximos : throw new ArgumentOutOfRangeException(nameof(intentosMaximos));
        IntentosRestantes = IntentosMaximos;
        _min = min;
        _max = max;
        IntentoActual = 0;
        IsGanado = false;
        IsPerdido = false;
    }

    public PistaTipo Adivinar(int intento)
    {
        if (IsGanado || IsPerdido) throw new InvalidOperationException("El juego ya terminó.");
        if (intento < _min || intento > _max) throw new ArgumentOutOfRangeException(nameof(intento), $"El intento debe estar entre {_min} y {_max}.");

        IntentoActual++;
        if (intento == Secreto)
        {
            IsGanado = true;
            return PistaTipo.Correcto;
        }

        int diff = Math.Abs(Secreto - intento);

        IntentosRestantes--;
        if (IntentosRestantes <= 0) IsPerdido = true;

        if (diff >= 50) return PistaTipo.Congelado;
        if (diff >= 20) return PistaTipo.Frio;
        if (diff >= 5) return PistaTipo.Tibio;
        return PistaTipo.Caliente;
    }
}