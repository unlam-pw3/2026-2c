using Clase1Tarea.Logica.IO;
using Clase1Tarea.Logica.Juego;
using Clase1Tarea.Logica.Providers;

int intentosIniciales = 6;

IConsola consola = new ConsolaWrapper();
IProveedorNumeros proveedor = new ProveedorNumeros();

int numeroSecreto = proveedor.ObtenerNumeroAleatorio();
IJuegoNumero juego = new JuegoNumero(numeroSecreto, intentosIniciales);

consola.EscribirLinea("Bienvenido al juego.");
consola.EscribirLinea($"Tendras {intentosIniciales} intentos para adivinar el numero secreto!");
consola.EscribirLinea();

while (juego.IntentosRestantes > 0 && !juego.IsGanado)
{
    int numeroIngresado = consola.LeerNumero();
    consola.EscribirLinea();

    string acierto = juego.Adivinar(numeroIngresado);
    if (acierto!="correcto")
    {
        consola.EscribirLinea($"Certeza: {acierto.ToUpper()} ,  Intentos restantes: {juego.IntentosRestantes}");
    }
}

consola.EscribirLinea();
if (!juego.IsGanado)
{
    consola.EscribirLinea($"GAME OVER. Se han utilizado todos los {intentosIniciales} intentos...");
    consola.EscribirLinea($"El numero secreto era: {numeroSecreto}");
}
else
{
    consola.EscribirLinea("¡Felicidades! Has adivinado el numero: " + numeroSecreto + ",  en el intento: "+juego.IntentosRestantes);
}


