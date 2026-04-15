namespace Clase1.Logica.Numero;

public interface IJuegoNumero
{
    string ObtenerPista(int secreto, int intento);
    bool EsGanador(int secreto, int intento);
}
