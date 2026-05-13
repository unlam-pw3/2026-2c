using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades;

public class Jugador
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public Personaje PersonajeElegido { get; set; }
    public Jugador()
    {
        PersonajeElegido = null;
    }
}
