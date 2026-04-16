using Clase_1_Tarea_juego_adivinanza.IO;
using Clase_1_Tarea_juego_adivinanza.Juego;

IConsola consola = new Consola();
// se puede agregar un numero deseado al constructor del juego
IJuegoAdivinanza juego = new JuegoAdivinanza();

consola.EscribirLinea("BIENVENIDO AL JUEGO DE ADIVINAR UN NUMERO DEL 1 AL 100!");
consola.EscribirLinea("");

while(!juego.JuegoGanado) {
    // El usuario ingresa un numero 
    consola.Escribir("Ingrese un numero del 1 al 100: ");
    string entrada = consola.LeerNumero();

    // El sistema verifica si adivino el numero
    consola.EscribirLinea(juego.AdivinarNumero(entrada));
}

consola.EscribirLinea($"Intentos realizados: {juego.IntentosRealizados}");