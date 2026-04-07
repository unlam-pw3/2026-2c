using System;

namespace JuegoNumero.Logica
{
    public class Numero : INumero
    {
        private readonly int _valorSecreto;

        public int Valor => _valorSecreto;
        public int Intentos { get; private set; }
        public bool IsGanado { get; private set; }

        public Numero(int valor)
        {
            this._valorSecreto = valor;
            this.Intentos = 0;
            this.IsGanado = false;
        }

        public string EnviarIntento(int intento)
        {
            Intentos++;
            if (intento == Valor)
            {
                IsGanado = true;
                return "Adivinaste el numero!";
            }
            else
            {
                return CalcularDiferencia(intento);
            }

        }

        public string CalcularDiferencia(int intento)
        {
            int diferencia = Math.Abs(Valor - intento);
            if (diferencia < 5)
            {
                return "caliente!";
            }
            else if (diferencia < 20)
            {
                return "tibio!";
            }
            else if (diferencia < 50)
            {
                return "frio!";
            }
            else
            {
                return "congelado!";
            }
        }
    }
}
