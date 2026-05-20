using Clase4.POO.Entidades.Habilidades;

namespace Clase4.POO.Entidades;

public class Personaje
{
    public int Id { get; set; }
    public string Imagen { get; set; }
    public string Nombre { get; set; } = "";
    public bool Derrotado { get; set; }
    public int HpActual { get; set; }
    public int HpInicial { get; set; }

    /// <summary>
    /// Al matar un personaje se sube XP. Al subir de nivel se pueden mejorar las habilidades, aumentar el hp, mana, etc.
    /// </summary>
    public int Xp { get; set; } = 0;
    protected Dictionary<int, List<IHabilidad>> Habilidades { get; } = new Dictionary<int, List<IHabilidad>>();
    public List<IHabilidad> ObtenerHabilidadesDisponibles()
    {
        return Habilidades
            .Where(h => h.Key <= Xp)
            .SelectMany(h => h.Value)
            .ToList();
    }

    public int Mana { get; set; }
    public int CapacidadMochila { get; set; }
    public int Monedas { get; set; }
    public Raza Raza { get; set; }
    public IAtaque AtaqueBasico { get; set; }

    public void AcumularExperiencia(Personaje personajeObjetivo)
    {
        if (personajeObjetivo == null)
            return;

        if (personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual = 0;
        }

        if (personajeObjetivo.HpActual == 0)
        {
            personajeObjetivo.Derrotado = true;
            Xp += 1000;
        }
    }

    public void EjecutarAtaqueBasico(Personaje personajeObjetivo)
    {
        if (personajeObjetivo == null)
            return;

        personajeObjetivo.HpActual -= AtaqueBasico.Daño;
        Xp += 50;

        AcumularExperiencia(personajeObjetivo);
    }

    public void EjecutarHabilidad(Guid idHabilidad, Personaje personajeObjetivo)
    {
        var habilidad = this.ObtenerHabilidadesDisponibles().FirstOrDefault(h => h.Id == idHabilidad);
        EjecutarHabilidad(habilidad, personajeObjetivo);
    }


    public void EjecutarHabilidad(IHabilidad habilidad, Personaje personajeObjetivo)
    {
        if (habilidad == null || personajeObjetivo == null || habilidad.TurnosPendientesParaEjecutar > 0)
            return;

        IResultadoHabilidad resultadoHabilidad = habilidad.Ejecutar(this, personajeObjetivo);
        habilidad.TurnosPendientesParaEjecutar += habilidad.Enfriamiento;

        if (resultadoHabilidad.HabilidadExitosa)
        {
            Xp += 200;
            AcumularExperiencia(personajeObjetivo);
        }
    }

    public void DisminuirEnfriamientos()
    {
        foreach (var habilidad in ObtenerHabilidadesDisponibles())
        {
            if (habilidad.TurnosPendientesParaEjecutar > 0)
            {
                habilidad.TurnosPendientesParaEjecutar--;
            }
        }
    }
}