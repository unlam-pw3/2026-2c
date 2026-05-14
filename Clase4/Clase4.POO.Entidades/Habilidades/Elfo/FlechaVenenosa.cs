
namespace Clase4.POO.Entidades.Habilidades.Elfo;

public class FlechaVenenosa: IHabilidad
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; } = "Flecha Venenosa";

    public int Coste => 100;

    public int Enfriamiento => 2;
    public int TurnosPendientesParaEjecutar { get; set; } = 0;

    public IResultadoHabilidad Ejecutar(Personaje personajeEjecutor, Personaje personajeObjetivo)
    {
        // Coste de mana - 100
        //chequear mana
        if (personajeEjecutor.Mana < Coste)
        {
            return new ResultadoHabilidadFallido("No tienes suficiente mana para usar esta habilidad.");
        }
        personajeEjecutor.Mana -= Coste;
        //Ataque + 500
        personajeObjetivo.HpActual -= 500;
        if (personajeObjetivo.HpActual < 0)
        {
            personajeObjetivo.HpActual = 0;
        }
        return new ResultadoHabilidadExitoso();
    }
}
