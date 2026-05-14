namespace Clase4.POO.Entidades.Habilidades.Hechicero;

public class BolaDeLava : IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Bola de Lava";
    public int Coste { get; } = 40;
    public int Enfriamiento => 3;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;
    /// <summary>
    /// + 300 ataque
    /// </summary>
    /// <param name="personaje"></param>
    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        // Coste de mana - 40
        //chequear mana
        if (personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad.");
        }
        personajeEjecutor.Mana -= Coste;
        //Ataque + 300
        personajeObjetivo.HpActual -= 300;
        if (personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual = 0;
        }
        return new ResultadoHabilidadExitoso();
    }
}