namespace Clase1.Logica.Numero;
public interface IJuegoNumero
{
    string Intentar(int numero);
    bool Terminado { get; }
    int Intentos { get; }
}
