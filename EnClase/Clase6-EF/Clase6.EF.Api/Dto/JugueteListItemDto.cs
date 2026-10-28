namespace Clase6.EF.Api.Dtos;

public class JugueteListItemDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int EdadRecomendada { get; set; }
    public int TematicaId { get; set; }
    public string? TematicaNombre { get; set; }
}