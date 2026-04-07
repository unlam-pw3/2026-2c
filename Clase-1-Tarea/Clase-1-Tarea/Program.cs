using System;
using Clase1.Logica.IO;
using JuegoNumero.Logica;

IConsola consola = new ConsolaWrapper();
IProveedorNumero proveedor = new ProveedorNumero();
int numeroSecreto = proveedor.ObtenerNumeroSecreto();

INumero juego = new Numero(numeroSecreto);

consola.EscribirLinea("Bienvenido al juego de adivinar el numero.");
consola.EscribirLinea("La unica pista es que está entre 1 y 100!");

while (!juego.IsGanado)
{
    consola.EscribirLinea("Introduce tu numero");
    string entrada = consola.LeerLinea();

    if (int.TryParse(entrada, out int intentoUsuario))
    {
        string pista = juego.EnviarIntento(intentoUsuario);
        consola.EscribirLinea($"Pista: {pista}");
    }
    else
    {
        consola.EscribirLinea("Por favor, ingresa un número válido.");
    }
}

consola.EscribirLinea($"¡Felicidades! Lo lograste en {juego.Intentos} intentos.");

Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();