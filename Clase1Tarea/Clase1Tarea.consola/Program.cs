using Clase1Tarea.Logica.IO;
using Clase1Tarea.Logica.Juego;

IConsola consola = new ConsolaWrapper();

int numeroAleatorio = new Random().Next(1, 101);
int numeroIngresado = 0;

IJuegoNumero juegoNumero = new JuegoNumero(numeroAleatorio);

consola.EscribirLinea("Bienvenido al juego de adivinar el número.");
consola.EscribirLinea("Tendras intentos ilimitados para adivinar el número secreto!");
consola.EscribirLinea();

while (!juegoNumero.HaGanado)
{
    //Pedir al usuario que ingrese un numero
    consola.EscribirLinea("Ingrese un número");
    numeroIngresado = Convert.ToInt32(consola.LeerLinea());

    //Verificar si el numero esta en el rango.
    if (!juegoNumero.VerificarNumero(numeroIngresado))
    {
        consola.EscribirLinea("Elija un número entre 1 y 100");
        continue;
    }

    string resultado = juegoNumero.Adivinar(numeroIngresado);
    consola.EscribirLinea(resultado);

    if (juegoNumero.HaGanado)
    {
        consola.EscribirLinea("Lo lograste en " + juegoNumero.Intentos + " intentos!");
    }
}