using JuegoNumero.Logica; // Esto conecta con el otro proyecto
using ConsoleApp1;

IConsola consola = new ConsolaReal();
IJuegoNumero juego = new JuegoTemperatura(new Random().Next(1, 101));
int intentos = 0;

consola.Escribir("¡Bienvenido al juego! Adiviná el número del 1 al 100.");

while (true)
{
    consola.Escribir("Tu intento: ");
    if (int.TryParse(consola.Leer(), out int intento))
    {
        intentos++;
        if (juego.EsCorrecto(intento))
        {
            consola.Escribir($"¡Ganaste! Lo hiciste en {intentos} intentos.");
            break;
        }
        consola.Escribir($"Pista: {juego.ObtenerPista(intento)}");
    }
}

consola.Escribir("Presioná una tecla para salir...");
Console.ReadKey();