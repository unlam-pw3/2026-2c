namespace JuegoNumeros
{
    public class JuegoNumero : IJuegoNumero
    {
        private int numeroSecreto;
        private int contador = 1;

        
        public JuegoNumero(int numeroSecreto)
        {
            this.numeroSecreto = numeroSecreto;
        }

        
        public JuegoNumero()
        {
            var random = new Random();
            numeroSecreto = random.Next(1, 101);
        }

        public Boolean perdiste()
        {
            

            if(contador >= 10)
            {
               
                return true;
            }
            contador++;
            return false;
        }
        public string SacarTemperatura(int numeroIntento)
        {
           
            
            if (perdiste())
            {
                return "Perdiste";
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