using Clase_1_Tarea_.IO;
using Clase_1_Tarea_.Juego;
using Clase_1_Tarea_.Providers;

//Preparación del juego, instanciando las clases necesarias.
IConsola consola = new IConsolaWrapper();
consola.EscribirLinea("Bienvenido a la Tarea de la clase 1. Vas a adivinar un numero entre el 1 y el 100");

IProveedorNumeros proveedorNumeros = new IProveedorNumerosWrapper();

IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
juego.Inicializar(1, 100, proveedorNumeros);

//Inicio del loop de juego. Se repite hasta ganar
bool terminado = false;
while (!terminado)
{
    //Se obtiene lo ingresado y se verifica que sea valido.
    consola.Escribir("Ingresa un número: ");
    string entrada = consola.LeerLinea();
    if (!int.TryParse(entrada, out int intento))
    {
        consola.EscribirLinea("Entrada inválida. Intenta de nuevo.");
        continue;
    }
    //Si es valido, se evalua el numero. Si es correcto el juego termina
    var (adivino, pista)  = juego.Evaluar(intento);
    if (adivino)
    {
        consola.EscribirLinea($"¡Felicidades! Adivinaste en {juego.Intentos} intentos.");
        terminado = true;
    }
    else
    //En caso de no serlo, se le da una pista al usuario. 
    {
        consola.EscribirLinea($"Pista: {pista}");
    }
}

//Fuera del loop, se muestra el numero objetivo 
consola.EscribirLinea($"El número era: {juego.NumeroObjetivo}");
consola.EscribirLinea("Gracias por jugar. Presiona ENTER para salir.");
consola.LeerLinea();
