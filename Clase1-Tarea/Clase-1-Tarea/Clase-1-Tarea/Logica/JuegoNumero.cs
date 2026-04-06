using Clase_1_Tarea.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea.JuegoNumero
{
    public class JuegoNumero : IO.IJuegoNumero
    {
        private int numeroSecreto;
        private Random random;
        private int intentos;

        public JuegoNumero()
        {
            //Constructor para iniciar el juego con un numero secreto aleatorio
            this.random = new Random();
            this.intentos = 0;
            this.numeroSecreto = this.random.Next(1, 101);
            reiniciar();
        }

        public JuegoNumero(int numeroSecreto)
        {
            //Constructor para testear el juego con un numero secreto fijo
            this.numeroSecreto = numeroSecreto ;
            intentos = 0;
            reiniciar();
        }
        public int getIntentos { get { return this.intentos; }  }
      
        public string resultadoJuegoNumero(int valorJugador)
        {

            //
            this.intentos++;
            //Generamos un numero aleatorio entre 1 y 100
            int diferencia = Math.Abs(numeroSecreto - valorJugador);
            string resultado = "";
         

            switch(diferencia)
            {
                case 0:
                    resultado = "Ganaste";
                    break;
                case int n when (n >= 50):
                    resultado = "Congelado";
                    break;
                case int n when (n >= 20 && n < 50):
                    resultado = "Frio";
                    break;
                case int n when (n < 20 && n >= 5):
                    resultado = "Tibio";
                    break;
                case int n when (n < 5):
                    resultado = "Caliente";
                    break;
            }

            return resultado;
            throw new NotImplementedException();
        }

        private void reiniciar()
        {
            this.intentos = 0;
            //this.numeroSecreto = this.random.Next(1, 101);
       
        }

    }
}
