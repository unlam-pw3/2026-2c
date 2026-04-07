using System;

namespace Clase_1_Tarea_.Providers
{
    public interface IProveedorNumeros
    {
        //Interfaz proveedor de numero random 
        int ObtenerNumeroRandom(int min, int max);
    }
}
