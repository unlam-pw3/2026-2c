using Clase4.POO.Entidades.Habilidades;
using Clase4.POO.Entidades.Habilidades.Hechicero;

namespace Clase4.POO.Entidades.Personajes;

public class Hechicero : Personaje
{
    public Hechicero()
    {
        Nombre = "Hechicero";
        Raza = Raza.Hechicero;
        Imagen = "hechicero.png";

        HpInicial = 700;
        Mana = 200;
        CapacidadMochila = 20;
        Monedas = 100;

        HpActual = HpInicial;

        Habilidades.Add(0, new List<IHabilidad>
        {
            new BolaDeFuego(),
            new Curacion(),
        });

        Habilidades.Add(1000, new List<IHabilidad>
        {
            new BolaDeLava()
        });

        AtaqueBasico = new AtaqueBasico("Rayo necrótico", 50);
    }
}
