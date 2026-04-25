using Clase1Tarea.Logica.Juego;

namespace Clase1Tarea.Test
{
    public class JuegoNumeroTest
    {

        [Theory]
        [InlineData(50, 100, "Congelado")] // diff = 50 → Congelado
        [InlineData(1, 80, "Congelado")]   // diff = 79 → Congelado
        public void Adivinar_Distancia_Mayor_O_Igual_50_Devuelve_Congelado(int secreto, int intento, string esperado)
        {
            var juego = new JuegoNumero(secreto);
            var resultado = juego.Adivinar(intento);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(50, 30, "Frio")]  // diff = 20 → Frio
        [InlineData(50, 71, "Frio")]  // diff = 21 → Frio
        [InlineData(10, 59, "Frio")]  // diff = 49 → Frio
        public void Adivinar_Distancia_Entre_20_Y_49_Devuelve_Frio(int secreto, int intento, string esperado)
        {
            var juego = new JuegoNumero(secreto);
            var resultado = juego.Adivinar(intento);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(50, 45, "Tibio")]  // diff = 5 → Tibio
        [InlineData(50, 31, "Tibio")]  // diff = 19 → Tibio
        [InlineData(20, 33, "Tibio")]  // diff = 13 → Tibio
        public void Adivinar_Distancia_Entre_5_Y_19_Devuelve_Tibio(int secreto, int intento, string esperado)
        {
            var juego = new JuegoNumero(secreto);
            var resultado = juego.Adivinar(intento);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(50, 49, "Caliente")]  // diff = 1 → Caliente
        [InlineData(50, 51, "Caliente")]  // diff = 1 → Caliente
        [InlineData(50, 47, "Caliente")]  // diff = 3 → Caliente
        public void Adivinar_Distancia_Menor_A_5_Devuelve_Caliente(int secreto, int intento, string esperado)
        {
            var juego = new JuegoNumero(secreto);
            var resultado = juego.Adivinar(intento);
            Assert.Equal(esperado, resultado);
        }

        // --- Test de ganar ---

        [Fact]
        public void Adivinar_Numero_Correcto_Gana()
        {
            var juego = new JuegoNumero(42);

            var resultado = juego.Adivinar(42);

            Assert.Equal("Ganaste", resultado);
            Assert.True(juego.HaGanado);
        }

        // --- Test de intentos ---

        [Fact]
        public void Adivinar_Numero_No_Correcto_Suma_Intento()
        {
            var juego = new JuegoNumero(10);

            juego.Adivinar(1);

            Assert.False(juego.HaGanado);
            Assert.Equal(1, juego.Intentos);
        }

        [Fact]
        public void Adivinar_Varios_Intentos_Cuenta_Correctamente()
        {
            var juego = new JuegoNumero(50);

            juego.Adivinar(1);
            juego.Adivinar(20);
            juego.Adivinar(50);

            Assert.True(juego.HaGanado);
            Assert.Equal(3, juego.Intentos);
        }

        // --- Test de verificar rango ---

        [Fact]
        public void VerificarNumero_Dentro_De_Rango_Devuelve_True()
        {
            var juego = new JuegoNumero(50);

            Assert.True(juego.VerificarNumero(1));
            Assert.True(juego.VerificarNumero(50));
            Assert.True(juego.VerificarNumero(100));
        }

        [Fact]
        public void VerificarNumero_Fuera_De_Rango_Devuelve_False()
        {
            var juego = new JuegoNumero(50);

            Assert.False(juego.VerificarNumero(0));
            Assert.False(juego.VerificarNumero(101));
            Assert.False(juego.VerificarNumero(-5));
        }

        // --- Test juego completo ---

        [Fact]
        public void Juego_Completo_Adivinando()
        {
            var juego = new JuegoNumero(30);

            var r1 = juego.Adivinar(80);   // diff = 50 → Congelado
            var r2 = juego.Adivinar(55);   // diff = 25 → Frio
            var r3 = juego.Adivinar(40);   // diff = 10 → Tibio
            var r4 = juego.Adivinar(28);   // diff = 2  → Caliente
            var r5 = juego.Adivinar(30);   // Ganaste

            Assert.Equal("Congelado", r1);
            Assert.Equal("Frio", r2);
            Assert.Equal("Tibio", r3);
            Assert.Equal("Caliente", r4);
            Assert.Equal("Ganaste", r5);
            Assert.True(juego.HaGanado);
            Assert.Equal(5, juego.Intentos);
        }
    }
}
