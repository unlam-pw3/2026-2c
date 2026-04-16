using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_1_Tarea_juego_adivinanza.Juego
{
    public interface IJuegoAdivinanza
    {
        public string AdivinarNumero(string entrada);
        public bool JuegoGanado { get; }
        public int IntentosRealizados { get; }
    }
}
