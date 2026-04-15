using System.Text;
using Clase1.Logica.IO;
using Clase1.Logica.Numero;

IConsola consola = new ConsolaWrapper();
IJuegoNumero juego = new JuegoNumero();
Random random = new();

int secreto = random.Next(1, 101);
int intentos = 0;

consola.EscribirLinea("Bienvenido al juego de adivinar el numero.");
consola.EscribirLinea("Debes adivinar un numero entre 1 y 100.");

while (true)
{
    consola.Escribir("Ingresa tu intento: ");
    string? entrada = LeerLinea(consola);

    if (!int.TryParse(entrada, out int intento))
    {
        consola.EscribirLinea("Entrada invalida. Debes ingresar un numero entero.");
        continue;
    }

    intentos++;

    if (juego.EsGanador(secreto, intento))
    {
        consola.EscribirLinea($"Adivinaste el numero en el intento {intentos}.");
        break;
    }

    string pista = juego.ObtenerPista(secreto, intento);
    consola.EscribirLinea($"Pista: {pista}");
}

static string? LeerLinea(IConsola consola)
{
    StringBuilder sb = new();

    while (true)
    {
        char tecla = consola.LeerTecla();
        if (tecla is '\r' or '\n')
        {
            return sb.ToString();
        }

        if (tecla == '\b')
        {
            if (sb.Length > 0)
            {
                sb.Length--;
            }

            continue;
        }

        sb.Append(tecla);
    }
}
