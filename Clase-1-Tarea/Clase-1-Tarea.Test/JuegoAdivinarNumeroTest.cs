using Clase_1_Tarea.Test;
using Clase_1_Tarea_.Juego; 
namespace Clase_1_Tarea.Test


{
    [TestClass]
    public sealed class JuegoAdivinarNumeroTest
    {
        //Tests unitarios 
        [TestMethod]
        public void Al_Adivinar_El_Numero_Correctamente_Gano()
        {
            //El numero random es el del constructor de la clase Mock.
            var proveedor = new MockProveedor(42);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            bool adivino;
            string pista = juego.Evaluar(42, out adivino);

            Assert.IsTrue(adivino);
            Assert.AreEqual("¡Correcto!", pista);
            Assert.AreEqual(1, juego.Intentos);
        }

        [TestMethod]
        public void Al_No_Adivinar_El_Numero_Correctamente_El_Juego_Sigue()
        {
            var proveedor = new MockProveedor(50);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            bool adivino; 
            juego.Evaluar(10, out adivino);

            Assert.IsFalse(adivino);
            Assert.AreEqual(1, juego.Intentos);
        }

        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Congelado_Si_Hay_Una_Dif_Mayor_A_50()
        {
            var proveedor = new MockProveedor(100);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 200, proveedor);

            bool adivino;
            string pista = juego.Evaluar(40, out adivino);

            Assert.IsFalse(adivino);
            Assert.AreEqual("congelado", pista);
        }

        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Frio_Si_Hay_Una_Dif_Entre_20_50()
        {
            var proveedor = new MockProveedor(60);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            bool adivino;
            string pista = juego.Evaluar(30, out adivino);

            Assert.IsFalse(adivino);
            Assert.AreEqual("frio", pista);
        }


        [TestMethod]
        public void Al_No_Adivinar_Obtengo_tibio_Si_Hay_Una_Dif_Entre_5_20()
        {
            var proveedor = new MockProveedor(40);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            bool adivino; 
            string pista = juego.Evaluar(30, out adivino);

            Assert.IsFalse(adivino);
            Assert.AreEqual("tibio", pista);
        }


        [TestMethod]
        public void Al_No_Adivinar_Obtengo_Caliente_Si_Hay_Una_Dif_Menor_A_5()
        {
            var proveedor = new MockProveedor(28);
            IJuegoAdivinarNumero juego = new JuegoAdivinarNumero();
            juego.Inicializar(1, 100, proveedor);

            bool adivino; 
            string pista = juego.Evaluar(25, out adivino);

            Assert.IsFalse(adivino);
            Assert.AreEqual("caliente", pista);
        }
    }
}
