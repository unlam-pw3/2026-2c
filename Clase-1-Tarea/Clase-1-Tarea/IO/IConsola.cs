using System;

namespace Clase_1_Tarea_.IO
{
    public interface IConsola
    {
        void EscribirLinea(string texto);
        void Escribir(string texto);
        string LeerLinea();
    }
}
