using System;

namespace Clase_1_Tarea_.IO
{
    public class IConsolaWrapper : IConsola
    {
        //Consola Wrapper. 
        public void EscribirLinea(string texto)
        {
            Console.WriteLine(texto);
        }

        public void Escribir(string texto)
        {
            Console.Write(texto);
        }

        public string LeerLinea()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
