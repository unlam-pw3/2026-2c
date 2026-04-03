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

// paso los valores maximos y minimos
IJuegoNumeros juego = new JuegoNumeros(min, max);
// genero el numero random
juego.Generar();

consola.EscribirLinea();
consola.EscribirLinea("Ahora intenta adivinar el número");

// mientras no esta finaliza, continua el juego. finaliza dentro del loop, y en la proxima ejecucion salta
while (!juego.Finalizado) 
{
consola.Escribir("Que número estas pensando? ");
int numeroElegido = consola.EscribirNumero();
string respuesta = juego.Pista(numeroElegido);
consola.EscribirLinea(respuesta);
}  

// informa juego finalizado
consola.EscribirLinea();
consola.Escribir("Juego Finalizado");