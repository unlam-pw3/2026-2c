using System;
using System.Collections.Generic;

namespace Clase1Tarea.Logica.Juego;

public class JuegoNumeroSecreto : IJuegoNumeroSecreto
{
    private readonly int numeroSecreto;
    private readonly HashSet<int> numerosAdivinados = new();

    public int NumeroSecreto => numeroSecreto;
    public IReadOnlyCollection<int> NumerosAdivinados => numerosAdivinados;
    public int CantidadIntentos { get; private set; }
    public bool ElNumeroFueAdivinado { get; private set; }

    public JuegoNumeroSecreto(int numeroSecreto)
    {
        this.numeroSecreto = numeroSecreto;
    }

    public bool Adivinar(int numeroIngresado)
    {
        if (ElNumeroFueAdivinado)
        {
            return true;
        }

        if (numeroIngresado < 1 || numeroIngresado > 100)
        {
            Console.WriteLine("Por favor, ingresa un número válido entre 1 y 100.");
            return false;
        }

        CantidadIntentos++;

        if (numeroIngresado == numeroSecreto)
        {
            ElNumeroFueAdivinado = true;
            Console.WriteLine($"¡Bravo! el número secreto era: {numeroSecreto}");
            return true;
        }

        numerosAdivinados.Add(numeroIngresado);
        var diferencia = Math.Abs(numeroSecreto - numeroIngresado);

        if (diferencia < 5)
        {
            Console.WriteLine("caliente");
        }
        else if (diferencia < 20)
        {
            Console.WriteLine("tibio");
        }
        else if (diferencia < 50)
        {
            Console.WriteLine("frio");
        }
        else
        {
            Console.WriteLine("congelado");
        }

        return false;
    }
}

