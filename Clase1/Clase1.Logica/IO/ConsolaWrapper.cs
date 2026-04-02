using System;

namespace Clase1.Logica.IO;

public class ConsolaWrapper : IConsola //el famoso "implements" de java
{
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto); // (= "") esto hace que se use por defecto "", si no estuviera ahi y no le pasamos nada generaria error, se pone aunque ya este en IConsola por si en algun momento tratamos de hacer ConsolaWrapper consola2 = new ConsolaWrapper(); y si no pasamos nada daria error.
    public char LeerTecla() => Console.ReadKey().KeyChar;
}
