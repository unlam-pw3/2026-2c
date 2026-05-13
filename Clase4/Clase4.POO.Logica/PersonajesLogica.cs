using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4.POO.Entidades;
using Clase4.POO.Entidades.Personajes;

namespace Clase4.POO.Logica;

public interface IPersonajesLogica
{
    public List<Personaje> ObtenerPersonajes();
    public Personaje ObtenerPersonajePorId(int id);
}

public class PersonajesLogica : IPersonajesLogica
{
    private static List<Personaje> _lista = new List<Personaje>()
    {
        new Elfo() { Id = 1},
        new Hechicero() { Id = 2},
    };

    public List<Personaje> ObtenerPersonajes()
    {
        return _lista;
    }

    public Personaje ObtenerPersonajePorId(int id)
    {
        return _lista.FirstOrDefault(p => p.Id == id);
    }
}
