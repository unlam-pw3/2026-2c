using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea_juego_adivinanza.IO
{
    public interface IConsola
    {
        public void EscribirLinea(string texto = "");
        public void Escribir(string texto);
        public string LeerNumero();
    }
}
