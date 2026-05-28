namespace Clase6.EF.Entidades;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public List<Juguete> Juguetes { get; set; } = new();
}
