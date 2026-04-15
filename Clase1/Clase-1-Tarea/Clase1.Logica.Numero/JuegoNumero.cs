namespace Clase1.Logica.Numero;

public class JuegoNumero : IJuegoNumero
{
    public string ObtenerPista(int secreto, int intento)
    {
        int diff = Math.Abs(secreto - intento);

        if (diff >= 50)
        {
            return "congelado";
        }

        if (diff >= 20)
        {
            return "frio";
        }

        if (diff >= 5)
        {
            return "tibio";
        }

        return "caliente";
    }

    public bool EsGanador(int secreto, int intento)
    {
        return secreto == intento;
    }
}
