using Clase_1_Tarea.JuegoNumero;
using System.Security.Cryptography;

string resultado = "";
//var juego = new JuegoNumero(55);
var juego = new JuegoNumero();

do
{

    Console.WriteLine("Ingrese un numero entre 1 y 100:");
    string input = Console.ReadLine();
  
    int valorJugador;

    if(!int.TryParse(input, out valorJugador))
    {
        Console.WriteLine("Por favor ingrese un numero valido entre 1 y 100.");
        continue;
    } else if (valorJugador < 1 || valorJugador > 100)
    {
        Console.WriteLine("Por favor ingrese un numero entre 1 y 100.");
        continue;
    }

    resultado = juego.resultadoJuegoNumero(valorJugador);

    Console.WriteLine(resultado);

} while (resultado != "Ganaste");

if(resultado == "Ganaste") {
    Console.WriteLine("Lo has logrado en el intento " + juego.getIntentos);
}
    



