namespace Clase_1_Tarea.Test
{
    [TestClass]
    public sealed class JuegoAdivinarNumeroTest
    {
        [TestMethod]
        public void Al_Adivinar_El_Numero_Correctamente_Gano()
        {
            var proveedor = new FixedProveedor(42);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            var resultado = juego.Evaluar(42);

            Assert.IsTrue(resultado.Adivino);
            Assert.AreEqual("¡Correcto!", resultado.Pista);
            Assert.AreEqual(1, juego.Intentos);
        }

        [TestMethod]
        public void Al_No_Adivinar_El_Numero_Correctamente_El_Juego_Sigue()
        {
            var proveedor = new FixedProveedor(50);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            var resultado = juego.Evaluar(10);

            Assert.IsFalse(resultado.Adivino);
            Assert.AreEqual(1, juego.Intentos);
        }

        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Congelado_Si_Hay_Una_Dif_Mayor_A_50()
        {
            var proveedor = new FixedProveedor(100);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 200, proveedor);

            var resultado = juego.Evaluar(40);

            Assert.IsFalse(resultado.Adivino);
            Assert.AreEqual("congelado", resultado.Pista);
        }

        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Frio_Si_Hay_Una_Dif_Entre_20_50()
        {
            var proveedor = new FixedProveedor(60);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            var resultado = juego.Evaluar(30);

            Assert.IsFalse(resultado.Adivino);
            Assert.AreEqual("frio", resultado.Pista);
        }


        [TestMethod]
        public void Al_No_Adivinar_Obtengo_tibio_Si_Hay_Una_Dif_Entre_5_20()
        {
            var proveedor = new FixedProveedor(40);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            var resultado = juego.Evaluar(30);

            Assert.IsFalse(resultado.Adivino);
            Assert.AreEqual("tibio", resultado.Pista);
        }


        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Caliente_Si_Hay_Una_Dif_Menor_A_5()
        {
            var proveedor = new FixedProveedor(28);
            var juego = new Clase_1_Tarea_.Juego.JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            var resultado = juego.Evaluar(25);

            Assert.IsFalse(resultado.Adivino);
            Assert.AreEqual("caliente", resultado.Pista);
        }

        private class FixedProveedor : Clase_1_Tarea_.Providers.IProveedorNumeros
        {
            private readonly int value;
            public FixedProveedor(int v) { this.value = v; }
            public int ObtenerNumeroRandom(int min, int max) => this.value;
        }
    }
}
