namespace Clase4.POO.Entidades.Habilidades.Hechicero;

public class BolaDeFuego : IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Bola de Fuego";
    public int Coste { get; } = 30;

    public int Enfriamiento => 2;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;

    /// <summary>
    /// + 200 ataque
    /// </summary>
    /// <param name="personaje"></param>
    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        // Coste de mana - 30
        //chequear mana
        if (personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad.");
        }

        personajeEjecutor.Mana -= Coste;

        //Ataque + 200
        personajeObjetivo.HpActual -= 200;
        if (personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual = 0;
        }

        return new ResultadoHabilidadExitoso();
    }
}