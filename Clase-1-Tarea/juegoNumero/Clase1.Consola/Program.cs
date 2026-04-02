using Clase1.Logica.IO;
using Clase1.Logica.Juego;

IConsola consola = new ConsolaWrapper();

consola.EscribirLinea("Intenta adivinar un numero generado al azar");
consola.Escribir("Comenza ingresando el número mínimo que se puede generar: ");
int min = consola.EscribirNumero();
consola.EscribirLinea();


consola.EscribirLinea();
consola.Escribir("Ahora ingresa el número máximo que se puede generar:");
int max = consola.EscribirNumero();
consola.EscribirLinea();

IJuegoNumeros juego = new JuegoNumeros(min, max);
int numeroSecreto = juego.Generar();

consola.EscribirLinea();
consola.EscribirLinea("Ahora intenta adivinar el número");

string respuesta = "";

while (!juego.Finalizado) 
{
consola.Escribir("Que número estas pensando? ");
int numeroElegido = consola.EscribirNumero();
respuesta = juego.Pista(numeroSecreto, numeroElegido);
consola.EscribirLinea(respuesta);
}  

consola.EscribirLinea();
consola.Escribir("Juego Finalizado");