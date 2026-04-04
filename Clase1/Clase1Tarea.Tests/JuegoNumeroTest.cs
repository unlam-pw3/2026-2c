
using Clase1.Logica.Juego;
using Clase1Tarea.Logica.Juego;

namespace Clase1Tarea.Tests;

public class JuegoNumeroTest
{
    [Fact]
    public void AdivinarNumeroIncorrectoRestaUnIntento()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(1);

        Assert.Equal("tibio", resultado);
        Assert.Equal(5, juego.IntentosRestantes);
    }
    [Fact]
    public void SiHayUnaDiferenciaDe50DevuelveCongelado()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(70);

        Assert.Equal("congelado", resultado);
        Assert.Equal(5, juego.IntentosRestantes);
    }
    [Fact]
    public void SiHayUnaDiferenciaDe49DevuelveFrio()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(69);

        Assert.Equal("frio", resultado);
        Assert.Equal(5, juego.IntentosRestantes);
    }

    [Fact]
    public void SiHayUnaDiferenciaDe19DevuelveTibio()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(39);

        Assert.Equal("tibio", resultado);
        Assert.Equal(5, juego.IntentosRestantes);
    }
    [Fact]
    public void SiHayUnaDiferenciaDe4DevuelveCaliente()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(24);

        Assert.Equal("caliente", resultado);
        Assert.Equal(5, juego.IntentosRestantes);
    }

    [Fact]
    public void SiHayUnaDiferenciaDe0DevuelveCorrecto()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(20);

        Assert.Equal("correcto", resultado);
        //no se resta intento si gana por eso
        Assert.Equal(6, juego.IntentosRestantes);
    }
    [Fact]
    public void JuegoSeGanaCuandoSeAdivinaElNumero()
    {
        var juego = new JuegoNumero(20);

        juego.Adivinar(20);

        Assert.True(juego.IsGanado);
        Assert.False(juego.IsPerdido);
    }

    [Fact]
    public void JuegoSePierdeCuandoSeAgotanLosIntentos()
    {
        var juego = new JuegoNumero(20);

        juego.Adivinar(1);
        juego.Adivinar(5);
        juego.Adivinar(16);
        juego.Adivinar(17);
        juego.Adivinar(18);
        juego.Adivinar(21);


        Assert.True(juego.IsPerdido);
        Assert.False(juego.IsGanado);
    }
    [Fact]
    public void SiAdivinoUnNumeroInvalidoDevuelveError()
    {
        var juego = new JuegoNumero(20);

        var resultado = juego.Adivinar(101);

        Assert.Equal("error", resultado);
    }

    [Fact]
    public void SiInstancioJuegoConNumeroInvalidoLanzaException()
    {
        var ex = Assert.Throws<ArgumentException>(() => new JuegoNumero(-1));

        Assert.Contains("El numero secreto debe estar entre 1 y 100.", ex.Message);
        Assert.Equal("numeroSecreto", ex.ParamName);
    }
    [Theory]
    [InlineData(20, "correcto")]     // Caso: Acierto exacto
    [InlineData(21, "caliente")]     // Caso: Diferencia < 5
    [InlineData(30, "tibio")]        // Caso: Diferencia entre 5 y 19
    [InlineData(50, "frio")]         // Caso: Diferencia entre 20 y 49
    [InlineData(80, "congelado")]    // Caso: Diferencia >= 50
    [InlineData(101, "error")]       // Caso: Fuera de rango superior
    [InlineData(0, "error")]         // Caso: Fuera de rango inferior
    [InlineData(-5, "error")]        // Caso: Negativo
    public void Adivinar_DebeRetornarMensajeCorrectoSegunRango(int numeroIngresado, string resultadoEsperado)
    {
        var juego = new JuegoNumero(numeroSecreto: 20);

        string resultado = juego.Adivinar(numeroIngresado);

        Assert.Equal(resultadoEsperado, resultado);
    }


}

