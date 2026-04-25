
namespace Clase1Tarea.Logica.Juego
{
    public interface IJuegoNumero
    {
        bool HaGanado { get; }
        bool VerificarNumero(int numeroIngresado);
        string Adivinar(int numeroIngresado);

        int Intentos { get; }

    }
}
