using Clase1.Logica.Juego;

namespace Clase1.Tests;

public class JuegoAhorcadoTest
{
    [Theory]
    [InlineData("casa", 'a', true, "_a_a")]
    [InlineData("casa", 'c', true, "c___")]
    [InlineData("casa", 's', true, "__s_")]
    public void Adivinar_LetraCorrecta_RevelaLaLetra(string palabraSecreta, 
        char letraIntento, 
        bool esValida, 
        string palabraEnmascarada)
    {
        var juego = new JuegoAhorcado("casa", intentosMaximos: 6);

        var resultado = juego.Adivinar('a');

        Assert.True(resultado);
        Assert.Equal("_a_a", juego.PalabraEnmascarada);
    }

    [Fact]
    public void Adivinar_LetraIncorrecta_RestaIntento()
    {
        var juego = new JuegoAhorcado("test", intentosMaximos: 3);

        var resultado = juego.Adivinar('z');

        Assert.False(resultado);
        Assert.Equal(2, juego.IntentosRestantes);
    }

    [Fact]
    public void Adivinar_LetraRepetida_NoRestaIntento()
    {
        var juego = new JuegoAhorcado("hola", intentosMaximos: 3);

        var primera = juego.Adivinar('x');
        var intentosDespuesPrimera = juego.IntentosRestantes;

        var segunda = juego.Adivinar('x');

        Assert.False(primera);
        Assert.False(segunda);
        Assert.Equal(intentosDespuesPrimera, juego.IntentosRestantes);
    }

    [Fact]
    public void Juego_SeGana_CuandoSeAdivinanTodasLasLetras()
    {
        var juego = new JuegoAhorcado("aa", intentosMaximos: 6);

        juego.Adivinar('a');

        Assert.True(juego.IsGanado);
        Assert.False(juego.IsPerdido);
    }

    [Fact]
    public void Juego_SePierde_CuandoSeAgotanLosIntentos()
    {
        var juego = new JuegoAhorcado("hola", intentosMaximos: 1);

        juego.Adivinar('z');

        Assert.True(juego.IsPerdido);
        Assert.False(juego.IsGanado);
    }

    [Fact]
    public void Adivinar_LetraMayuscula_EquivalenteAMinuscula()
    {
        var juego = new JuegoAhorcado("casa", intentosMaximos: 6);

        var resultado = juego.Adivinar('A');

        Assert.True(resultado);
        Assert.Equal("_a_a", juego.PalabraEnmascarada);
    }

    [Fact]
    public void Adivinar_CaracterNoAlfabetico_LanzaArgumentException()
    {
        var juego = new JuegoAhorcado("test", intentosMaximos: 3);
        var resultado = juego.Adivinar('1');

        Assert.False(resultado);
    }

    [Fact]
    public void Juego_Completo_Ganando()
    {
        var juego = new JuegoAhorcado("ab", intentosMaximos: 6);

        juego.Adivinar('a');
        juego.Adivinar('b');

        Assert.True(juego.IsGanado);
        Assert.False(juego.IsPerdido);
    }

    [Fact]
    public void Juego_Completo_Perdiedo()
    {
        var juego = new JuegoAhorcado("xyz", intentosMaximos: 2);

        juego.Adivinar('a');
        juego.Adivinar('b');

        Assert.True(juego.IsPerdido);
        Assert.False(juego.IsGanado);
    }
}
