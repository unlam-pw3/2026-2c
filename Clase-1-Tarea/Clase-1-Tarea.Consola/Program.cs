using Clase_1_Tarea_.IO;
using Clase_1_Tarea_.Juego;
using Clase_1_Tarea_.Providers;

IConsola consola = new IConsolaWrapper();
consola.EscribirLinea("Bienvenido a la Tarea de la clase 1. Vas a adivinar un numero entre el 1 y el 100");

IProveedorNumeros proveedorNumeros = new IProveedorNumerosWrapper();

IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
juego.Inicializar(1, 100, proveedorNumeros);

bool terminado = false;
while (!terminado)
{
    consola.Escribir("Ingresa un número: ");
    string entrada = consola.LeerLinea();
    if (!int.TryParse(entrada, out int intento))
    {
        consola.EscribirLinea("Entrada inválida. Intenta de nuevo.");
        continue;
    }

    var resultado = juego.Evaluar(intento);
    if (resultado.Adivino)
    {
        consola.EscribirLinea($"¡Felicidades! Adivinaste en {juego.Intentos} intentos.");
        terminado = true;
    }
    else
    {
        consola.EscribirLinea($"Pista: {resultado.Pista}");
    }
}

consola.EscribirLinea($"El número era: {juego.NumeroObjetivo}");
consola.EscribirLinea("Gracias por jugar. Presiona ENTER para salir.");
consola.LeerLinea();
