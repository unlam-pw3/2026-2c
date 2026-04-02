using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1.Logica.Providers;

public class ProveedorPalabrasEstatico : IProveedorPalabras
{
    private readonly List<string> palabras;
    private readonly Random random;

    public ProveedorPalabrasEstatico(IEnumerable<string> palabras, Random? random = null)
    {
        this.palabras = palabras?.ToList() ?? new List<string> { "programacion", "consola", "csharp", "desarrollo", "juego" };
        this.random = random ?? new Random();
    }

    public string ObtenerPalabraAleatoria()
    {
        if (palabras.Count == 0) throw new InvalidOperationException("No hay palabras disponibles.");
        return palabras.OrderBy(x => random.Next()).First();
    }
}
