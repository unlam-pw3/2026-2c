using System;
using Clase1.Logica.Numero;

class Program
{
    static void Main()
    {
        var random = new Random();
        int secreto = random.Next(1, 101);

        var juego = new JuegoNumero(secreto);

        Console.WriteLine("🎮 Adivina el número (1-100)");

        while (!juego.Terminado)
        {
            Console.Write("👉 Ingresá un número: ");
            
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int intento))
            {
                Console.WriteLine("❌ Ingresá un número válido");
                continue;
            }

            string resultado = juego.Intentar(intento);
            Console.WriteLine(resultado);
        }

        Console.WriteLine("🏁 Juego terminado");
    }
}
