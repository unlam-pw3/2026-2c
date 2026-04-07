using System;

namespace Clase1.Logica.IO;

public class ConsolaWrapper : IConsola
{
    public void Escribir(string texto) => Console.Write(texto);
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
    public char LeerTecla() => Console.ReadKey().KeyChar;

    public string LeerLinea()
    {
        string? entrada = Console.ReadLine();
        return entrada ?? string.Empty;
    }
}
