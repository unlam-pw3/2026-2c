namespace Clase1.Tests;

public class JuegoNumeroTest
{
    // genero y testeo varias veces para evaluar que no se genere un random fuera de rango
    [Fact]
    public void NoSeGeneraUnNumeroFueraDelRango()
    {
        const int min = 1;
        const int max = 50;
        var juego = new JuegoNumeros (min, max);
               
        var numero1 = juego.Generar();
        Assert.InRange(numero1, min, max);
        
        var numero2 = juego.Generar();
        Assert.InRange(numero2, min, max);
        var numero3 = juego.Generar();
        Assert.InRange(numero3, min, max);
        var numero4 = juego.Generar();
        Assert.InRange(numero4, min, max);
        var numero5 = juego.Generar();
        Assert.InRange(numero5, min, max);
        var numero6 = juego.Generar();
        Assert.InRange(numero6, min, max);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos3DevuelveCaliente()
    {
        var juego = new JuegoNumeros (1, 100);
        // genero para definir los valores limites
        var numero = juego.Generar();
        // fuerzo el valor del numero random para poder testear
        juego.NumeroRandom = 7;
        var respuesta = juego.Pista(10);

        Assert.Equal("CALIENTE!", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsExactamente4DevuelveCaliente()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 14;

        var respuesta = juego.Pista(10);

        Assert.Equal("CALIENTE!", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos5DevuelveTibio()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 5;
        
        var respuesta = juego.Pista(10);

        Assert.Equal("Tibio Tibio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs19DevuelveTibio()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 20;
        
        var respuesta = juego.Pista(1);

        Assert.Equal("Tibio Tibio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos20DevuelveFrio()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 10;
        
        var respuesta = juego.Pista(30);

        Assert.Equal("Friiiiio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs49DevuelveFrio()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 50;
        
        var respuesta = juego.Pista(1);

        Assert.Equal("Friiiiio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos50DevuelveCongelado()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 10;
        
        var respuesta = juego.Pista(60);

        Assert.Equal("En el freezer", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs99DevuelveCongelado()
    {
        var juego = new JuegoNumeros (1, 100);
        var numero = juego.Generar();
        juego.NumeroRandom = 100;
        
        var respuesta = juego.Pista(1);

        Assert.Equal("En el freezer", respuesta);
    }

    // quiza seria conveniente separar este test?
    [Fact]
    public void SiNoHayDiferenciaDevuelveAciertoYCantidadDeIntentos()
    {
        var juego = new JuegoNumeros (1, 100);
        juego.NumeroRandom = 28;
        
        // juego dos veces, pero solo guardo la segunda para el test
        juego.Pista(35);
        var respuesta = juego.Pista(28);

        Assert.Equal("Lo conseguiste en 2 intentos", respuesta);
    }

    [Fact]
    public void ContabilizaCorrectamenteLosIntentosEnTodosLosEscenarios()
    {
        var juego = new JuegoNumeros (1, 100);
        juego.NumeroRandom = 88;
        
        juego.Pista(1);
        juego.Pista(20);
        juego.Pista(50);
        juego.Pista(120);
        juego.Pista(88);

        Assert.Equal(5, juego.Intentos);
    }

        [Fact]
        public void SiElNumeroElegidoEstaFueraDelRangoDevuelveEquivocado()
    {
        var juego = new JuegoNumeros (1, 4);
        juego.Generar();

        var respuesta = juego.Pista(5);

        Assert.Equal("No existe el 5, señor", respuesta);
    }

}
