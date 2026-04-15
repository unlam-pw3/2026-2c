using Clase1.Logica.Numero;
using Xunit;

namespace Clase1.Tests.Numero;

public class JuegoNumeroTests
{
    [Theory]
    [InlineData(100, 1, PistaTipo.Congelado)] // diff 99
    [InlineData(60, 30, PistaTipo.Frio)]      // diff 30
    [InlineData(40, 33, PistaTipo.Tibio)]     // diff 7
    [InlineData(50, 47, PistaTipo.Caliente)]  // diff 3
    public void Adivinar_DevuelveLaPistaEsperada(int secreto, int intento, PistaTipo pistaEsperada)
    {
        var juego = new JuegoNumero(secreto, intentosMaximos: 6, min: 1, max: 100);

        var pista = juego.Adivinar(intento);

        Assert.Equal(pistaEsperada, pista);
    }

    [Fact]
    public void Adivinar_Correcto_MarcaComoGanado_YCuentaIntento()
    {
        var juego = new JuegoNumero(secreto: 10, intentosMaximos: 6);

        juego.Adivinar(1);
        juego.Adivinar(5);
        var pista = juego.Adivinar(10);

        Assert.True(juego.IsGanado);
        Assert.False(juego.IsPerdido);
        Assert.Equal(3, juego.IntentoActual);
        Assert.Equal(PistaTipo.Correcto, pista);
    }

    [Fact]
    public void AgotarIntentos_MarcaComoPerdido()
    {
        var juego = new JuegoNumero(secreto: 99, intentosMaximos: 2);

        juego.Adivinar(1); // incorrecto
        juego.Adivinar(2); // incorrecto -> agotado

        Assert.True(juego.IsPerdido);
        Assert.False(juego.IsGanado);
        Assert.Equal(0, juego.IntentosRestantes);
    }
}
