namespace JuegoNumero.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_Pista_Congelado()
    {
        // Arrange: Secreto es 100, intento es 10 (diff = 90)
        var juego = new JuegoTemperatura(100);

        // Act
        var resultado = juego.ObtenerPista(10);

        // Assert
        Assert.Equal("congelado", resultado);
    }
}
