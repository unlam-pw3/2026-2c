using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1Tarea.Logica.Providers;

public class ProveedorNumeros : IProveedorNumeros
{
    private readonly Random random;

    public ProveedorNumeros(Random? random = null)
    {
        this.random = random ?? new Random();
    }

    public int ObtenerNumeroAleatorio()
    {
        return random.Next(1, 101);// devuelve un entero aleatorio entre 1 y 100
    }
}
