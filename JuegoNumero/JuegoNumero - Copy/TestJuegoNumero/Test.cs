using Xunit;



namespace JuegoNumeros.Tests
{
    public class JuegoTests
        
    {
        

        [Theory]
        [InlineData(25,"Caliente")]
        [InlineData(51,"Frio")]
        [InlineData(31,"Tibio")]
        [InlineData(100,"Congelado")]
        [InlineData(21,"Adivinaste El Numero")]
        
        public void CuandoElUsuarioEscribeUnNumeroTieneQueDevolverleElMensajeCorrectoDependiendoLaDiferencia(int intento,string mensajeEsperado)
        {
            //Caliente
            var juego = new JuegoNumero(21);
            var resultado = juego.SacarTemperatura(intento);
           
            Assert.Equal(mensajeEsperado, resultado);

        }

        [Fact]
        public void Gana_cuando_adivina()
        {
            var juego = new JuegoNumero(25);

            var resultado = juego.SacarTemperatura(25);

            Assert.Equal("Adivinaste el numero", resultado);
        }
        [Fact]
        public void PierdeCuandoIntentaMasDe10VecesErroneasYDevuelveLaPalabraPerdiste()
        {
            var juego = new JuegoNumero(20);
            var resultado = juego.SacarTemperatura(25);
            var resultado1 = juego.SacarTemperatura(25);
            var resultado2 = juego.SacarTemperatura(25);
            var resultado3 = juego.SacarTemperatura(25);
            var resultado4 = juego.SacarTemperatura(25);
            var resultado5 = juego.SacarTemperatura(25);
            var resultado6 = juego.SacarTemperatura(25);
            var resultado7 = juego.SacarTemperatura(25);
            var resultado8 = juego.SacarTemperatura(25);
            var resultado9 = juego.SacarTemperatura(25);
            var resultado10 = juego.SacarTemperatura(25);

            Assert.Equal("Perdiste el juego", resultado10);
        }



        [Fact]
        public void Caliente_si_diff_menor_a_5()
        {
            var juego = new JuegoNumero(25);

            var resultado = juego.SacarTemperatura(23);

            Assert.Equal("Caliente", resultado);
        }

        [Fact]
        public void Tibio_si_diff_entre_5_y_19()
        {
            var juego = new JuegoNumero(25);

            var resultado = juego.SacarTemperatura(10);

            Assert.Equal("Tibio", resultado);
        }

        [Fact]
        public void Frio_si_diff_entre_20_y_49()
        {
            var juego = new JuegoNumero(50);

            var resultado = juego.SacarTemperatura(10);

            Assert.Equal("Frio", resultado);
        }

        [Fact]
        public void Congelado_si_diff_mayor_o_igual_a_50()
        { 
            var juego = new JuegoNumero(100);

            var resultado = juego.SacarTemperatura(1);

            Assert.Equal("Congelado", resultado);
        }
    }
}