
namespace JuegoNumero.Logica
{
    public interface INumero
    {
        int Valor { get; }
        int Intentos { get; }
        bool IsGanado { get; }

        string EnviarIntento(int intento);
    }
}