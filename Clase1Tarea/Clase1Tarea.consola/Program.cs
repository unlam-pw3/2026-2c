
//Juego adivinar el numero
int intentos = 0;
//Elegir un numero aleatorio

int numeroMinimoInclusive = 1;
int numeroMaximoInclusive = 100;

int numeroAleatorio = new Random().Next(numeroMinimoInclusive, numeroMaximoInclusive + 1);

int numeroIngresado = 0;
int distancia = 0;


while (numeroIngresado != numeroAleatorio)
{
    //Pedir al usuario que ingrese un numero
    Console.WriteLine("Ingrese un numero");
    numeroIngresado = Convert.ToInt32(Console.ReadLine());

    //Verificar si el numero esta en el rango.
    if (numeroIngresado < numeroMinimoInclusive || numeroIngresado > numeroMaximoInclusive)
    {
        Console.WriteLine("Elija un número entre " + (numeroMinimoInclusive) + " y " + (numeroMaximoInclusive));
        continue;
    }

    intentos++;

    distancia = numeroAleatorio - numeroIngresado;
    if (distancia < 0)
    {
        distancia = distancia * -1;
    }

    if (numeroIngresado == numeroAleatorio)
    {
        Console.WriteLine("Ganaste! con " + (intentos) + " intentos" );
    } else if (distancia >= 50)
    {
        Console.WriteLine("Congelado");
    } else if (distancia >=20 && distancia < 50)
    {
        Console.WriteLine("Frio");
    } else if (distancia >= 5 && distancia < 20)
    {
        Console.WriteLine("Tibio");
    } else if (distancia < 5)
    {
        Console.WriteLine("Caliente");
    }

}


//Si el numero ingresado es menor o mayor al numero aleatorio, informar al usuario que tan lejos o cerca esta.

//Si el numero ingresado es el aleatorio, felicitar al usuario y mostrar el numero de intentos. 

//Repetir el proceso hasta que el usuario adivine el numero.