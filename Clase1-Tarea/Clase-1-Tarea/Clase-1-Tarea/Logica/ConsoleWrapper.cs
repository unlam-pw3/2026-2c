using Clase_1_Tarea.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea.Logica
{
    public class ConsoleWrapper : IConsola
    {
        public void escribirLinea(string linea)
        {
            Console.WriteLine(linea);
            throw new NotImplementedException();
        }

        public void leerLinea(string linea)
        {
            linea=Console.ReadLine();
            throw new NotImplementedException();
        }
    }
}
