using System;

namespace Clase1.Logica.IO;

public class ConsolaWrapper : IConsola
{
    // inicia el juego generando una clase Random
    public void IniciarJuego() => Console.Write("Numero generado, intenta adivinarlo");
    
    // para escribir en consola una linea continua
    public void Escribir(string texto = "") => Console.Write(texto);
    
    // para escribir en consola con salto de linea
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
    
    // secuencia para garantizar que solo ingrese numeros (generada con IA)
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
