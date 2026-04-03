using Clase1Tarea.Logica.Juego;
using System;
using System.IO;

namespace Clase1Tarea.Tests;

public class JuegoNumeroSecretoTests
{
    [Fact]
    public void Adivinar_NumeroIncorrecto_SumaIntento()
    {
        var juego = new JuegoNumeroSecreto(numeroSecreto: 5);

        var resultado = juego.Adivinar(3);

        Assert.False(resultado);
        Assert.Equal(1, juego.CantidadIntentos);
    }

    [Fact]
    public void Adivinar_NumeroFueraDeRango_NoSumaIntento()
    {
        var juego = new JuegoNumeroSecreto(numeroSecreto: 50);

        var resultado = juego.Adivinar(101);

        Assert.False(resultado);
        Assert.Equal(0, juego.CantidadIntentos);
    }

    [Theory]
    [InlineData(54, "caliente")]
    [InlineData(65, "tibio")]
    [InlineData(90, "frio")]
    [InlineData(100, "congelado")]
    public void Adivinar_NumeroIncorrecto_MuestraPistaSegunDistancia(int numeroIngresado, string pistaEsperada)
    {
        var juego = new JuegoNumeroSecreto(numeroSecreto: 50);

        var salida = CapturarSalidaConsola(() => juego.Adivinar(numeroIngresado));

        Assert.Contains(pistaEsperada, salida, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Adivinar_NumeroCorrecto_GanaPartida()
    {
        var juego = new JuegoNumeroSecreto(numeroSecreto: 42);

        var resultado = juego.Adivinar(42);

        Assert.True(resultado);
        Assert.True(juego.ElNumeroFueAdivinado);
        Assert.Equal(1, juego.CantidadIntentos);
    }

    [Fact]
    public void Adivinar_NumeroIncorrecto_NoGanaPartida()
    {
        var juego = new JuegoNumeroSecreto(numeroSecreto: 42);

        var resultado = juego.Adivinar(41);

        Assert.False(resultado);
        Assert.False(juego.ElNumeroFueAdivinado);
        Assert.Equal(1, juego.CantidadIntentos);
    }

    private static string CapturarSalidaConsola(Action accion)
    {
        var salidaOriginal = Console.Out;
        using var writer = new StringWriter();

        try
        {
            Console.SetOut(writer);
            accion();
            return writer.ToString();
        }
        finally
        {
            Console.SetOut(salidaOriginal);
        }
    }
}