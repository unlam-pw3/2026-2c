namespace Clase1.Tests;

public class JuegoNumeroTest
{
    [Fact]
    public void NoSeGeneraUnNumeroFueraDelRango()
    {
        var juego = new JuegoNumeros (1, 2);
               
        var numero = juego.Generar();
        juego.Pista(numero, 1);
        
        Assert.InRange(numero, 1, 2);
        Assert.InRange(numero, 1, 2);
        Assert.InRange(numero, 1, 2);
        Assert.InRange(numero, 1, 2);
        Assert.InRange(numero, 1, 2);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos3DevuelveCaliente()
    {
        var juego = new JuegoNumeros (7, 7);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 10);

        Assert.Equal(7, numero);
        Assert.Equal("CALIENTE!", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsExactamente4DevuelveCaliente()
    {
        var juego = new JuegoNumeros (14, 14);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(14, 10);

        Assert.Equal(14, numero);
        Assert.Equal("CALIENTE!", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos5DevuelveTibio()
    {
        var juego = new JuegoNumeros (5, 5);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 10);

        Assert.Equal(5, numero);
        Assert.Equal("Tibio Tibio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs19DevuelveTibio()
    {
        var juego = new JuegoNumeros (20, 20);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 1);

        Assert.Equal(20, numero);
        Assert.Equal("Tibio Tibio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos20DevuelveFrio()
    {
        var juego = new JuegoNumeros (10, 10);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 30);

        Assert.Equal(10, numero);
        Assert.Equal("Friiiiio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs49DevuelveFrio()
    {
        var juego = new JuegoNumeros (50, 50);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 1);

        Assert.Equal(50, numero);
        Assert.Equal("Friiiiio", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEsMenos50DevuelveCongelado()
    {
        var juego = new JuegoNumeros (10, 10);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 60);

        Assert.Equal(10, numero);
        Assert.Equal("En el freezer", respuesta);
    }

    [Fact]
    public void SiLaDiferenciaEs99DevuelveCongelado()
    {
        var juego = new JuegoNumeros (100, 100);
        
        var numero = juego.Generar();
        juego.Min = 1;
        juego.Max = 100;
        var respuesta = juego.Pista(numero, 1);

        Assert.Equal(100, numero);
        Assert.Equal("En el freezer", respuesta);
    }

    [Fact]
    public void SiNoHayDiferenciaDevuelveAciertoYCantidadDeIntentos()
    {
        var juego = new JuegoNumeros (28, 28);
        
        var numero = juego.Generar();
        juego.Pista(numero, 35);
        var respuesta = juego.Pista(numero, 28);

        Assert.Equal("Lo conseguiste en 2 intentos", respuesta);
    }

        [Fact]
        public void SiElNumeroElegidoEstaFueraDelRangoDevuelveEquivocado()
    {
        var juego = new JuegoNumeros (1, 4);
        
        var numero = juego.Generar();
        var respuesta = juego.Pista(numero, 5);

        Assert.Equal("No existe el 5, señor", respuesta);
    }

}
