using Clase1.Logica.IO;
using Clase1.Logica.Providers;
using Clase1.Logica.Juego;

int intentosIniciales = 6;

IConsola consola = new ConsolaWrapper();
IProveedorPalabras proveedor = new ProveedorPalabrasEstatico(new[] { "programacion", "consola", "csharp", "desarrollo", "juego" });

string palabraSecreta = proveedor.ObtenerPalabraAleatoria();
IJuegoAhorcado juego = new JuegoAhorcado(palabraSecreta, intentosIniciales);

consola.EscribirLinea("Bienvenido al juego del ahorcado.");
consola.EscribirLinea($"Tendras {intentosIniciales} intentos para adivinar la palabra secreta!");
consola.EscribirLinea();

while (juego.IntentosRestantes > 0 && !juego.IsGanado)
{
    consola.EscribirLinea(juego.PalabraEnmascarada.Replace("_", " _"));
    char letra = consola.LeerTecla();
    consola.EscribirLinea();

    bool acierto = juego.Adivinar(letra);
    if (!acierto)
    {
        consola.EscribirLinea("Letra incorrecta. Intentos restantes: " + juego.IntentosRestantes);
    }
}

consola.EscribirLinea();
if (!juego.IsGanado)
{
    consola.EscribirLinea($"GAME OVER. Se han utilizado todos los {intentosIniciales} intentos...");
}
else
{
    consola.EscribirLinea("¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
}


