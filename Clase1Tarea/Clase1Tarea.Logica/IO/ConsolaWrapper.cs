using System;

namespace Clase1Tarea.Logica.IO;

public class ConsolaWrapper : IConsola
{
    public void Escribir(string texto) => Console.Write(texto);
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);

    public string LeerLinea() => Console.ReadLine() ?? string.Empty;
}
