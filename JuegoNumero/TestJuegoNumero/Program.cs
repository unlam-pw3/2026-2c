using JuegoNumeros;

var juego = new JuegoNumero();

Console.WriteLine("Adiviná el número entre 1 y 100");

while (true)
{
    Console.Write("Ingresá un número: ");

    var input = Console.ReadLine();

    

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Ingresá un número válido");
        continue;
    }

    if (!int.TryParse(input, out int intento))
    {
        Console.WriteLine("Ingresá un número válido");
        continue;
    }

    var resultado = juego.SacarTemperatura(intento);

    Console.WriteLine(resultado);

    if (resultado == "Perdiste")
    
        break;
    

    if (resultado == "Adivinaste el numero")
        break;
}