using Clase1.Logica.IO;
using Clase1.Logica.Numero;
using System;

class Program
{
    static void Main()
    {
        IConsola consola = new Clase1.Logica.IO.ConsolaWrapper();

        const int min = 1;
        const int max = 100;
        const int intentos = 6;

        var rnd = new Random();
        int secreto = rnd.Next(min, max + 1);

        var juego = new JuegoNumero(secreto, intentos, min, max);

        consola.EscribirLinea("Adivina el número secreto.");
        consola.EscribirLinea($"Rango: {min}..{max}. Tienes {intentos} intentos.");
        consola.EscribirLinea();

        while (!juego.IsGanado && !juego.IsPerdido)
        {
            consola.Escribir("Introduce un número: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int intento))
            {
                consola.EscribirLinea("Entrada inválida. Introduce un número entero.");
                continue;
            }

            try
            {
                var pista = juego.Adivinar(intento);
                if (pista == PistaTipo.Correcto)
                {
                    consola.EscribirLinea($"¡Correcto! Has adivinado en el intento {juego.IntentoActual}.");
                    break;
                }
                else
                {
                    consola.EscribirLinea(pista switch
                    {
                        PistaTipo.Congelado => "congelado",
                        PistaTipo.Frio => "frio",
                        PistaTipo.Tibio => "tibio",
                        PistaTipo.Caliente => "caliente",
                        _ => "sin pista"
                    } + $". Intentos restantes: {juego.IntentosRestantes}");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                consola.EscribirLinea(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                consola.EscribirLinea(ex.Message);
                break;
            }
        }

        if (juego.IsPerdido)
        {
            consola.EscribirLinea($"Has perdido. El número secreto era {secreto}.");
        }

        consola.EscribirLinea("Fin del juego. Pulsa una tecla para salir.");
        Console.ReadKey();
    }
}