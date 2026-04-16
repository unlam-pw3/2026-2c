using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea_juego_adivinanza.IO
{
    public class Consola : IConsola
    {
        public void EscribirLinea(string texto = "") => Console.WriteLine(texto);
        public void Escribir(string texto) => Console.Write(texto);
        public string LeerNumero() => Console.ReadLine();
    }
}
