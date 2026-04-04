namespace JuegoNumero.Logica;

public interface IJuegoNumero
{
    string ObtenerPista(int intento);
    bool EsCorrecto(int intento);
}

public class JuegoTemperatura : IJuegoNumero
{
    private readonly int _numeroSecreto;

    public JuegoTemperatura(int numeroSecreto)
    {
        _numeroSecreto = numeroSecreto;
    }

    public string ObtenerPista(int intento)
    {
        int diff = Math.Abs(_numeroSecreto - intento);
        if (diff >= 50) return "congelado";
        if (diff >= 20) return "frio";
        if (diff >= 5) return "tibio";
        return "caliente";
    }

    public bool EsCorrecto(int intento) => intento == _numeroSecreto;
}
