using System;
using Clase_1_Tarea_.Providers;

namespace Clase_1_Tarea_.Juego
{
    public class JuegoAdivinarNumero : IJuegoAdivinarNumero
    {
        //Implementación del juego.
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

        //Inicializa el juego: Genera el numero y registra la cant. de intentos. 
        public void Inicializar(int min, int max, IProveedorNumeros proveedor)
        {
            this.numeroObjetivo = proveedor.ObtenerNumeroRandom(min, max);
            this.intentos = 0;
        }

        //Evalua el numero ingresado, retorna si es correcto y una pista acorde a la diferencia
        public String Evaluar(int intento, out bool adivino)
        {
            this.intentos++;
            int diferencia = Math.Abs(this.numeroObjetivo - intento);
            adivino = (diferencia == 0);
            return getPista(diferencia);
        }

        //Retorna la pista segun la diferencia. 
        public String getPista(int diferencia)
            {
                if (diferencia == 0)
                {
                    return ("¡Correcto!");
                }

                if (diferencia >= 50)
                {
                    return ("congelado");
                }

                if (diferencia >= 20)
                {
                    return ("frio");
                }

                if (diferencia >= 5)
                {
                    return ("tibio");
                }

                return ("caliente");
            }
        }
}
