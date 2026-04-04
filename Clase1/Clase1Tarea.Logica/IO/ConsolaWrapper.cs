using System;

namespace Clase1Tarea.Logica.IO;

public class ConsolaWrapper : IConsola
{
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
    public int LeerNumero()
    {
        int numero;

        // bucle infinito
        while (true)
        {
            Console.Write("Ingrese un numero (entre 1 y 100): ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // 2. Verificamos si el número está en el rango permitido
                if (numero >= 1 && numero <= 100)
                {
                    return numero; 
                }
                else
                {
                    Console.WriteLine("Error: El numero debe estar entre 1 y 100. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Por favor ingrese un número.");
            }
        }
    }
}
