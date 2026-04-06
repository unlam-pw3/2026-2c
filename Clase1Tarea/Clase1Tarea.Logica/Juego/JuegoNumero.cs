
namespace Clase1Tarea.Logica.Juego
{
    public class JuegoNumero : IJuegoNumero
    {   
        private readonly int numeroAleatorio;
        public int Intentos { get; private set; }
        public JuegoNumero(int numeroAleatorio) { 
            this.numeroAleatorio = numeroAleatorio;
        }

        public bool VerificarNumero(int numeroIngresado)
        {
            if (numeroIngresado < 1 || numeroIngresado > 100)
            {
                return false;
            } else
            {
                return true;
            }
        }
        public bool HaGanado { get; private set; }

        public string Adivinar(int numeroIngresado)
        {
            Intentos++;
            if (numeroIngresado == numeroAleatorio)
            {
                HaGanado = true;
                return "Ganaste";
            }
            int distancia = numeroAleatorio - numeroIngresado;
            if (distancia < 0) distancia = distancia * -1;
            if (distancia >= 50) return "Congelado";
            else if (distancia >= 20) return "Frio";
            else if (distancia >= 5) return "Tibio";
            else return "Caliente";
        }
    }
}
