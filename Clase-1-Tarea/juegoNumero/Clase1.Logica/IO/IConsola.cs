namespace Clase1.Logica.IO;

public interface IConsola
{
    void Escribir(string texto);
    void EscribirLinea(string texto = "");
    char LeerTecla();
}