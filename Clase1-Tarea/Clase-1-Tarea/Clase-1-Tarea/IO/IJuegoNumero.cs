using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea.IO
{
    public interface IJuegoNumero
    {
        string resultadoJuegoNumero(int valorJugador);
        int getIntentos { get; }
    }
}
