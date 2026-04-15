using Clase1.Logica.Numero;

namespace Clase1.Logica.Numero.Tests;

public class JuegoNumeroTests
{
    private readonly IJuegoNumero _juego = new JuegoNumero();

    [Fact]
    public void ObtenerPista_DiffMayorOIgualA50_RetornaCongelado()
    {
        string pista = _juego.ObtenerPista(secreto: 100, intento: 50);

        Assert.Equal("congelado", pista);
    }

    [Fact]
    public void ObtenerPista_DiffEntre20Y49_RetornaFrio()
    {
        string pista = _juego.ObtenerPista(secreto: 100, intento: 80);

        Assert.Equal("frio", pista);
    }

    [Fact]
    public void ObtenerPista_DiffEntre5Y19_RetornaTibio()
    {
        string pista = _juego.ObtenerPista(secreto: 100, intento: 90);

        Assert.Equal("tibio", pista);
    }

    [Fact]
    public void ObtenerPista_DiffMenorA5_RetornaCaliente()
    {
        string pista = _juego.ObtenerPista(secreto: 100, intento: 97);

        Assert.Equal("caliente", pista);
    }

    [Fact]
    public void EsGanador_CuandoDiffEs0_RetornaTrue()
    {
        bool resultado = _juego.EsGanador(secreto: 42, intento: 42);

        Assert.True(resultado);
    }

    [Fact]
    public void EsGanador_CuandoDiffEsMayorA0_RetornaFalse()
    {
        bool resultado = _juego.EsGanador(secreto: 42, intento: 41);

        Assert.False(resultado);
    }

    [Theory]
    [InlineData(100, 95, "tibio")]      // diff = 5
    [InlineData(100, 80, "frio")]       // diff = 20
    [InlineData(100, 50, "congelado")]  // diff = 50
    public void ObtenerPista_CasosBorde_RetornaCategoriaEsperada(int secreto, int intento, string esperado)
    {
        string pista = _juego.ObtenerPista(secreto, intento);

        Assert.Equal(esperado, pista);
    }
}
