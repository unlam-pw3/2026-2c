namespace Clase1.Logica.IO;

public interface IConsola
{
    void IniciarJuego();
    void Escribir(string texto = "");
    void EscribirLinea(string texto = "");
    int EscribirNumero();
}