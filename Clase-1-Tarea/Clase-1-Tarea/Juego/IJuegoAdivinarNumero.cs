using System;
using Clase_1_Tarea_.Providers;

namespace Clase_1_Tarea_.Juego
{
    public interface IJuegoAdivinarNumero
    {
        //Interfaz del juego. 
        void Inicializar(int min, int max, IProveedorNumeros proveedor);
        (bool Adivino, string Pista) Evaluar(int intento);
        String getPista(int diferencia);
        int Intentos { get; }
        int NumeroObjetivo { get; }
    }
}
