namespace Clase6.EF.Api.Dto;

public class JugueteQueryDto
{
    public string? Nombre { get; set; }
    public int? TematicaId { get; set; }
    public decimal? PrecioMin { get; set; }
    public decimal? PrecioMax { get; set; }
    public string? SortBy { get; set; } = "id";
    public string? SortDir { get; set; } = "asc";
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
