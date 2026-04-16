using Clase_1_Tarea_juego_adivinanza.Juego;

namespace Tarea.Test
{
    public class JuegoAdivinanzaTest
    {
        [Fact]
        public void debidoAQueEstoyJugandoUnaPartidaConElNumero15AlIngresarDistintosIntentosMuestroSuEstadoDeCercania()
        {
            IJuegoAdivinanza juego = new JuegoAdivinanza(15);

            string intentoCongelado = juego.AdivinarNumero("70");
            string intentoFrio = juego.AdivinarNumero("35");
            string intentoTibio = juego.AdivinarNumero("20");
            string intentoCaliente = juego.AdivinarNumero("16");

            Assert.Equal("Congelado", intentoCongelado);
            Assert.Equal("Frio", intentoFrio);
            Assert.Equal("Tibio", intentoTibio);
            Assert.Equal("Caliente", intentoCaliente);
        }

        [Fact]
        public void debidoAQueEstoyJugandoUnaPartidaConElNumero15AlIngresarUnNumeroCorrectoGanoLaPartida()
        {
            IJuegoAdivinanza juego = new JuegoAdivinanza(15);

            juego.AdivinarNumero("15");

            Assert.True(juego.JuegoGanado);
        }

        [Fact]
        public void debidoAQueEstoyJugandoUnaPartidaConElNumero15AlIngresarUnNumeroCorrectoYGanoLaPartidaAparecenLosIntentosRealizados()
        {
            IJuegoAdivinanza juego = new JuegoAdivinanza(15);

            juego.AdivinarNumero("10");
            juego.AdivinarNumero("11");
            juego.AdivinarNumero("12");
            juego.AdivinarNumero("13");
            juego.AdivinarNumero("14");
            juego.AdivinarNumero("15");

            int intentosRealizados = juego.IntentosRealizados;

            Assert.True(juego.JuegoGanado);
            Assert.Equal(6, intentosRealizados);
        }
    }
}
