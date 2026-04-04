namespace ConsoleApp1;

public interface IConsola
{
    void Escribir(string mensaje);
    string Leer();
}

public class ConsolaReal : IConsola
{
    public void Escribir(string mensaje) => Console.WriteLine(mensaje);
    public string Leer() => Console.ReadLine() ?? "";
}