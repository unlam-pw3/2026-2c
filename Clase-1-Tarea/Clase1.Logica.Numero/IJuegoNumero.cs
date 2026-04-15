namespace Clase1.Logica.Numero;

public enum PistaTipo
{
    Congelado,
    Frio,
    Tibio,
    Caliente,
    Correcto
}

public interface IJuegoNumero
{
    int IntentosMaximos { get; }
    int IntentosRestantes { get; }
    int IntentoActual { get; }
    bool IsGanado { get; }
    bool IsPerdido { get; }
    int Secreto { get; }

    PistaTipo Adivinar(int intento);
}