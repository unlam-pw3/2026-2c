using System;
using System.Collections.Generic;
using System.Text;
using Clase_1_Tarea_.Providers;

namespace Clase_1_Tarea.Test
{
    internal class MockProveedor : IProveedorNumeros
    {
        //Mock del proveedor
        private readonly int value;
        public MockProveedor(int v) { this.value = v; }
        public int ObtenerNumeroRandom(int min, int max)
        {
            return this.value;
        }
    }
}
