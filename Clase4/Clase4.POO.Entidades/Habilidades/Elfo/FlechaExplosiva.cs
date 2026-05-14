namespace Clase4.POO.Entidades.Habilidades.Elfo;

internal class FlechaExplosiva : IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Flecha Explosiva";
    public int Coste { get; } = 150;
    public int Enfriamiento => 3;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;
    
    /// <summary>
    /// Ataque + 700
    /// </summary>
    /// <param name="personaje"></param>
    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        // Coste de mana - 150
        //chequear mana
        if (personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad.");
        }

        if (TurnosPendientesParaEjecutar > 0)
        {
            return new ResultadoHabilidadFallido("La habilidad está en enfriamiento.");
        }

        personajeEjecutor.Mana -= Coste;
        //Ataque + 700
        personajeObjetivo.HpActual -= 700;

        return new ResultadoHabilidadExitoso();
    }
}
