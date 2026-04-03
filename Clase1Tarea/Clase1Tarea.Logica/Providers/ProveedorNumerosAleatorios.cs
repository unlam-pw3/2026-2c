using System;

namespace Clase1Tarea.Logica.Providers;

public class ProveedorNumerosAleatorios : IProveedorNumeros
{
    private readonly Random random;

    public ProveedorNumerosAleatorios(Random? random = null)
    {
        this.random = random ?? new Random();
    }

    public int ObtenerNumeroAleatorio()
    {
        return random.Next(1, 101);
    }
}
