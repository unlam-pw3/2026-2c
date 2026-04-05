using Xunit;
using Clase1.Logica.Numero;
public class JuegoNumeroTests
{
    [Fact]
    public void Congelado_si_diff_mayor_igual_50()
    {
        var juego = new JuegoNumero(100);
        var resultado = juego.Intentar(0);

        Assert.Equal("Congelado", resultado);
    }

    [Fact]
    public void Frio_si_diff_entre_20_y_49()
    {
        var juego = new JuegoNumero(50);
        var resultado = juego.Intentar(10);

        Assert.Equal("Frio", resultado);
    }

    [Fact]
    public void Tibio_si_diff_entre_5_y_19()
    {
        var juego = new JuegoNumero(50);
        var resultado = juego.Intentar(40);

        Assert.Equal("Tibio", resultado);
    }

    [Fact]
    public void Caliente_si_diff_menor_5()
    {
        var juego = new JuegoNumero(50);
        var resultado = juego.Intentar(48);

        Assert.Equal("Caliente", resultado);
    }

    [Fact]
    public void Gana_cuando_acierta()
    {
        var juego = new JuegoNumero(50);
        var resultado = juego.Intentar(50);

        Assert.True(juego.Terminado);
        Assert.Contains("Correcto", resultado);
    }
}