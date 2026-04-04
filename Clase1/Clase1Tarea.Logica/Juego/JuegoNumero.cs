using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1Tarea.Logica.Juego
{
    // Lógica del juego separada para poder testearla sin depender de la consola
    public class JuegoNumero : IJuegoNumero
    {
        private readonly int numeroSecreto;

        public int IntentosRestantes { get; private set; }
        public bool IsGanado { get; private set; } = false;
        public bool IsPerdido => IntentosRestantes <= 0 && !IsGanado;

        public JuegoNumero(int numeroSecreto, int intentosMaximos = 6)
        {
            if (numeroSecreto<=0||numeroSecreto>100) throw new ArgumentException("El numero secreto debe estar entre 1 y 100.", nameof(numeroSecreto));
            this.numeroSecreto = numeroSecreto;
            IntentosRestantes = intentosMaximos;
        }

        public string Adivinar(int numero)
        {

            if (numero < 1 || numero > 100)
            {
                Console.WriteLine("Número no válido");
                return "error";
            }

            int diff = 0;
            if (numero > numeroSecreto)
            {
                diff = numero - numeroSecreto;
            }
            else
            {
                diff = numeroSecreto - numero;
            }
            string acierto = "";
            switch (diff)
            {
                case int n when (n == 0):
                    IsGanado = true;
                    acierto = "correcto";
                    break;
                case int n when (n < 5):
                    acierto = "caliente";
                    break;
                case int n when (n >= 5 && n < 20):
                    acierto = "tibio";
                    break;
                case int n when (n >= 20 && n < 50):
                    acierto = "frio";
                    break;
                case int n when (n >= 50 && n<100):
                    acierto = "congelado";
                    break;
                default:
                    Console.WriteLine("numero no valido");
                    acierto = "error";
                    break;
            }

            if (diff > 0) IntentosRestantes--;

            return acierto;
        }
    }
}
