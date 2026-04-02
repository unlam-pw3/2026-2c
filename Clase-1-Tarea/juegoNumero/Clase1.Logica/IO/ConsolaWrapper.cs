using System;

namespace Clase1.Logica.IO;

public class ConsolaWrapper : IConsola
{
    public void IniciarJuego() => Console.Write("Numero generado, intenta adivinarlo");
    public void Escribir(string texto = "") => Console.Write(texto);
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
    public int EscribirNumero()
    {
        string?  input = Console.ReadLine();
        int numero;
        while (!int.TryParse(input, out numero))
        {
            Console.Write("Ingresá solamente números");
            input = Console.ReadLine();
        }
        return numero;
    }
}
