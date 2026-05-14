using Clase4.POO.Entidades.Habilidades;

namespace Clase4.POO.Entidades;

public interface IHabilidad
{
    Guid Id { get; set; }
    public string Nombre { get; }
    public int Coste { get; }
    public int Enfriamiento { get; }
    public int TurnosPendientesParaEjecutar { get; set; }

    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo);
}