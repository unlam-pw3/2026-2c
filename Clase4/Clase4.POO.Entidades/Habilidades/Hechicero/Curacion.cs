using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.Habilidades.Hechicero;

public class Curacion : IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Curacion";
    public int Coste { get; } = 20;

    public int Enfriamiento => 2;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;

    /// <summary>
    /// + 300 hp
    /// </summary>
    /// <param name="personaje"></param>
    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        // Coste de mana - 20
        //chequear mana
        if (personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad.");
        }

        personajeEjecutor.Mana -= Coste;

        personajeObjetivo = personajeEjecutor;
        //Curacion + 300 hp
        personajeObjetivo.HpActual += 300;
        if (personajeObjetivo.HpActual > personajeObjetivo.HpInicial)
        {
            personajeObjetivo.HpActual = personajeObjetivo.HpInicial;
        }

        return new ResultadoHabilidadExitoso();
    }
}   