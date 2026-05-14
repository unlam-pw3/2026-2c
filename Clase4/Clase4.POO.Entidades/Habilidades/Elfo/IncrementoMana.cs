namespace Clase4.POO.Entidades.Habilidades.Elfo;

public class IncrementoMana : IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Incremento de Mana";
    public int Coste { get; } = 20;

    public int Enfriamiento => 1;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;

    /// <summary>
    /// + 50 mana
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
        //Mana + 50
        personajeEjecutor.Mana += 50;
        return new ResultadoHabilidadExitoso();
    }
}