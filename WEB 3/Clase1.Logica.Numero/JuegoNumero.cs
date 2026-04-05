using System;

namespace Clase1.Logica.Numero;

public class JuegoNumero : IJuegoNumero
{
    private readonly int secreto;
    public int Intentos { get; private set; }
    public bool Terminado { get; private set; }

    public JuegoNumero(int numeroSecreto)
    {
        secreto = numeroSecreto;
        Intentos = 0;
        Terminado = false;
    }

    public string Intentar(int numero)
    {
        if (Terminado) return "Juego terminado";

        Intentos++;

        if (numero == secreto)
        {
            Terminado = true;
            return $"¡Correcto! Lo adivinaste en {Intentos} intentos.";
        }

        int diff = Math.Abs(secreto - numero);

        if (diff >= 50) return "Congelado";
        if (diff >= 20) return "Frio";
        if (diff >= 5) return "Tibio";
        return "Caliente";
    }
}