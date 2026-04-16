using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea_juego_adivinanza.Juego
{
    public class JuegoAdivinanza : IJuegoAdivinanza
    {

        private readonly int numeroSecreto;
        private readonly Random ran;
        private bool juegoGanado = false;
        private int intentos = 0;

        public bool JuegoGanado => juegoGanado;
        public int IntentosRealizados => intentos;

        public JuegoAdivinanza(int numeroSecreto = 0)
        {
            this.ran = new Random();
            this.numeroSecreto = numeroSecreto != 0 ? numeroSecreto : ran.Next(0, 101);
        }

        public string AdivinarNumero(string entrada)
        {
            int numero = int.Parse(entrada);
            int diff = this.numeroSecreto - numero;

            diff = diff < 0 ? diff * (-1) : diff;

            intentos++;

            return EstadoAdivinanza(diff);
        }

        private string EstadoAdivinanza(int diff)
        {
            // Cercania = diff >= 50 --> "Congelado"
            // Cercania = 20 <= diff < 50 --> "Frio"
            // Cercania = 5 <= diff < 20 --> "Tibio"
            // Cercania = diff < 5 --> "Caliente"
            string estado = (diff >= 50) ? "Congelado" : 
                (20 <= diff && diff < 50) ? "Frio" : 
                    (5 <= diff && diff < 20) ? "Tibio" :
                        (diff < 5 && diff >= 1) ? "Caliente" : 
                            $"ADIVINASTE" ;

            this.juegoGanado = estado == "ADIVINASTE" ? true : this.juegoGanado;

            return estado;
        }
    }
}
