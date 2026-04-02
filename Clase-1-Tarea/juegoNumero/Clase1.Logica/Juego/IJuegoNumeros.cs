
namespace Clase1.Logica.Juego
{
    public interface IJuegoNumeros
    {
        int Generar();
        int Intentos {get; }
        int Min {get; set;}
        int Max {get; set;}
    }
}