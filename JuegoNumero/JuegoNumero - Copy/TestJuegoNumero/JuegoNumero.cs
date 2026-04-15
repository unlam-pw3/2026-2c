namespace JuegoNumeros
{
    public class JuegoNumero : IJuegoNumero
    {
        private int numeroSecreto;
        private int contador;

        // Constructor para tests (clave)
        public JuegoNumero(int numeroSecreto)
        {
            this.numeroSecreto = numeroSecreto;
        }

        // Constructor normal (para jugar)
        public JuegoNumero()
        {
            var random = new Random();
            numeroSecreto = random.Next(1, 101);
        }

        public Boolean perdiste()
        {
            contador++;
            if (contador >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string SacarTemperatura(int numeroIntento)
        {
            if (perdiste())
            {
                return "Perdiste el juego";
            }

            int diff = Math.Abs(numeroSecreto - numeroIntento);

            if (diff == 0)
                return "Adivinaste el numero";

            if (diff < 5)
                return "Caliente";

            if (diff < 20)
                return "Tibio";

            if (diff < 50)
                return "Frio";

            return "Congelado";
        }
    }
}