using Clase1Tarea.Logica.IO;
using Clase1Tarea.Logica.Providers;
using Clase1Tarea.Logica.Juego;

IConsola consola = new ConsolaWrapper();
IProveedorNumeros proveedor = new ProveedorNumerosAleatorios();

int numeroSecreto = proveedor.ObtenerNumeroAleatorio();
IJuegoNumeroSecreto juego = new JuegoNumeroSecreto(numeroSecreto);

consola.EscribirLinea("Bienvenido al juego del número secreto.");
consola.EscribirLinea("Tendrás que adivinar el número secreto entre 1 y 100.");
consola.EscribirLinea();

while (!juego.ElNumeroFueAdivinado)
{
    consola.Escribir("Ingresa un número entre 1 y 100 y presiona Enter: ");

    if (!int.TryParse(consola.LeerLinea(), out var numeroIngresado))
    {
        consola.EscribirLinea("Por favor, ingresa un número válido.");
        consola.EscribirLinea();
        continue;
    }

    juego.Adivinar(numeroIngresado);
    consola.EscribirLinea();
}

consola.EscribirLinea($"Ganaste en {juego.CantidadIntentos} intentos.");