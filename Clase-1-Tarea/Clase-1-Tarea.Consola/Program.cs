Console.WriteLine("Bienvenido a la Tarea de la clase 1. Vas a adivinar un numero entre el 1 y el 100 /n " +
    "Luego de ingresar su numero presiona una letra cualquiera!");

//Generear un bumero random 1- 100 (Entero)

int numeroRandom = new Random().Next(1, 101);

//Usuario ingresa su numero //(Se debe usar el enter tambien)

bool adivino = false;

do
{

    int numeroDelUsuario;
    List<char> numerosIngresados = new List<char>();
    char input;
    do
    {
        input = Console.ReadKey().KeyChar;
        if (numerosIngresados.Count > 3)
        {
            break;
        }
        if (char.IsDigit(input))
        {
            numerosIngresados.Add(input);
        }
        else
        {
            break;
        }
    } while (char.IsDigit(input));

    //Convertir la lista de caracteres a un numero entero

    numeroDelUsuario = int.Parse(new string(numerosIngresados.ToArray()));

    //Se compara el numero del usuario con el numero random

    int diferencia = Math.Abs(numeroDelUsuario - numeroRandom);

    //En caso de adivinar el numero, se le felicita al usuario y se repite el juego

    if (diferencia == 0)
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
    }

    String palabraPista = obtenerLaPalabraPista(diferencia);

    Console.Write(palabraPista);

} while (adivino == false);

Console.WriteLine($"El numero random era: {numeroRandom}");

static String obtenerLaPalabraPista(int num)
{
    String palabra = "";
    switch (num)
    {
        case >= 50:
            palabra = "congelado";
            break;
        case >= 20 and < 50:
            palabra = "frio";
            break;
        case >= 5 and < 20:
            palabra = "tibio";
            break;
        case < 5:
            palabra = "caliente";
            break;
    }
    return palabra; 
};