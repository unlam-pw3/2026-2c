
namespace Clase1.Logica.Juego
{
    public interface IJuegoNumeros
    {

        // unicas variables y metodos q llamo desde la interfaz (en ConsolaWrapper)
        bool Finalizado {get; set; }
        int Generar();
        string Pista (int numeroElegido);

    }
}