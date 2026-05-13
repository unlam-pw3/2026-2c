namespace Clase4.POO.Entidades.Personajes;

public class Elfo : Personaje
{
    public Elfo()
    {
        Raza = Raza.Elfo;
        Imagen = "elfo.png";
        Nombre = "Elfo";

        HpInicial = 1200;
        Mana = 150;
        CapacidadMochila = 30;
        Monedas = 150;

        HpActual = HpInicial;

        Habilidades.Add(0, new List<IHabilidad>
        {
                new Habilidades.Elfo.FlechaVenenosa(),
                new Habilidades.Elfo.IncrementoMana()
        });
        Habilidades.Add(1000, new List<IHabilidad>
        {
            new Habilidades.Elfo.FlechaExplosiva()
        });

        AtaqueBasico = new AtaqueBasico("Flecha", 30);
    }
}
