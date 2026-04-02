using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1.Logica.Providers;

public class ProveedorPalabrasEstatico : IProveedorPalabras
{
    private readonly List<string> palabras; //readonly significa que esa variable solo se puede asignar una vez 
    private readonly Random random;

    public ProveedorPalabrasEstatico(IEnumerable<string> palabras, Random? random = null) //IEnumerable es una Interfaz que significa "cualquier cosa que se pueda recorrer y contenga strings" puede ser un List<string>, un string[] (array), un HashSet<string>, etc. Cualquiera que se pueda recorrer con foreach. Random? significa que es nullable y por defecto se pasa null.
    {
        this.palabras = palabras?.ToList() ?? new List<string> { "programacion", "consola", "csharp", "desarrollo", "juego" }; // "palabras?.ToList() ??" significa "si palabras no es null, conviertelo a una lista, sino, crea una nueva lista con las palabras por defecto"
        this.random = random ?? new Random(); //significa "si random no es null, asignalo sino crea una nueva instancia de Random"
    }

    public string ObtenerPalabraAleatoria()
    {
        if (palabras.Count == 0) throw new InvalidOperationException("No hay palabras disponibles.");
        return palabras.OrderBy(x => random.Next()).First(); //El x => random.Next() es una lambda: por cada palabra x genera un número aleatorio, y .OrderBy(...) las ordena por ese número. El resultado es una mezcla. Después .First() agarra la primera.
    }
}
