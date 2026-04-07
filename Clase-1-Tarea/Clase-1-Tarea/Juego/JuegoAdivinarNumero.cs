using System;
using Clase_1_Tarea_.Providers;

namespace Clase_1_Tarea_.Juego
{
    public class JuegoAdivinarNumero : IJuegoAdivinarNumero
    {
        private int numeroObjetivo;
        private int intentos;

        public int Intentos
        {
            get { return this.intentos; }
        }

        public int NumeroObjetivo
        {
            get { return this.numeroObjetivo; }
        }

        public void Inicializar(int min, int max, IProveedorNumeros proveedor)
        {
            this.numeroObjetivo = proveedor.ObtenerNumeroRandom(min, max);
            this.intentos = 0;
        }

        public (bool Adivino, string Pista) Evaluar(int intento)
        {
            this.intentos = this.intentos + 1;
            int diferencia = Math.Abs(intento - this.numeroObjetivo);
            if (diferencia == 0)
            {
                return (true, "¡Correcto!");
            }

            if (diferencia >= 50)
            {
                return (false, "congelado");
            }

            if (diferencia >= 20)
            {
                return (false, "frio");
            }

            if (diferencia >= 5)
            {
                return (false, "tibio");
            }

            return (false, "caliente");
        }
    }
}
