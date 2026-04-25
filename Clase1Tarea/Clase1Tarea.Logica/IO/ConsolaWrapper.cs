
namespace Clase1Tarea.Logica.IO;

public class ConsolaWrapper : IConsola
{
    public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
    public string LeerLinea() => Console.ReadLine();
}