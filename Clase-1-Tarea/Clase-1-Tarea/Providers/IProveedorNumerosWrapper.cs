using System;

namespace Clase_1_Tarea_.Providers
{
    public class IProveedorNumerosWrapper : IProveedorNumeros
    {
        //Retorna el numero random. 
        public int ObtenerNumeroRandom(int min, int max)
        {
            return Random.Shared.Next(min, max + 1);
        }
    }
}
