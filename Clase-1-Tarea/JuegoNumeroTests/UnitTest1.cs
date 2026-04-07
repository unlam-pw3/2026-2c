using JuegoNumero.Logica;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JuegoNumeroTests
{
    public class UnitTest1
    {
        [Fact]
        public void Acertar_Numero_Es_Victoria()
        {
            var juego = new Numero(33);

            var resultado = juego.EnviarIntento(33);

            Assert.True(juego.IsGanado);

        }

        [Fact]
        public void No_Acierta_Numero()
        {
            var juego = new Numero(33);

            var resultado = juego.EnviarIntento(30);

            Assert.False(juego.IsGanado);
        }

        [Theory]
        [InlineData(33, 30, "caliente!")]
        [InlineData(33, 20, "tibio!")]
        [InlineData(33, 10, "frio!")]
        [InlineData(33, 90, "congelado!")]
        public void Pista_Correcta_Segun_Diferencia(int numeroSecreto, int numeroIntentado, string pistaEsperada)
        {
            var juego = new Numero(numeroSecreto);

            var pistaObtenida = juego.CalcularDiferencia(numeroIntentado);

            Assert.False(juego.IsGanado);
            Assert.Equal(pistaEsperada, pistaObtenida);
        }
    }
}
