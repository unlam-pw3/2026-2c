using Clase_1_Tarea.JuegoNumero;

namespace Tests
{
    public class JuegoNumeroTest
    {
        [Fact]
        public void queMeDevuelvaCongelado()
        {
            //Si la diferencia es mayor o igual a 50 deberia devolver congelado
            var juego = new JuegoNumero(55);
            int valorJugador = 5;
            string resultado = juego.resultadoJuegoNumero(valorJugador);

            Assert.Equal("Congelado", resultado);
        }
        [Fact]
        public void queMeDevuelvaFrio()
        {

            var juego = new JuegoNumero(55);
            int valorJugador = 30;
            string resultado = juego.resultadoJuegoNumero(valorJugador);

            Assert.Equal("Frio", resultado);
        }
        [Fact]
        public void queMeDevuelvaTibio()
        {

            var juego = new JuegoNumero(55);
            int valorJugador = 45;
            string resultado = juego.resultadoJuegoNumero(valorJugador);

            Assert.Equal("Tibio", resultado);
        }
        [Fact]
        public void queMeDevuelvaCaliente()
        {

            var juego = new JuegoNumero(55);
            int valorJugador = 53;
            string resultado = juego.resultadoJuegoNumero(valorJugador);

            Assert.Equal("Caliente", resultado);
        }

        [Fact]
        public void queMeDevuelvaSiGane()
        {
            var juego = new JuegoNumero(55);
            int valorJugador = 55;
            string resultado = juego.resultadoJuegoNumero(valorJugador);

            Assert.Equal("Ganaste", resultado);
        }

        [Fact]
        public void queMeDevuelvaCorrectamenteLosIntentos()
        {
            var juego = new JuegoNumero(55);
            int valorJugador = 5;
            juego.resultadoJuegoNumero(valorJugador); //1 intento
            juego.resultadoJuegoNumero(valorJugador); //2 intento
            juego.resultadoJuegoNumero(valorJugador); //3 intento
            Assert.Equal(3, juego.getIntentos);
        }
    }
}