using System.ComponentModel.DataAnnotations;

namespace Clase6.EF.Api.Dto;

public class JugueteCrearDto
{
    [Required]
    [MaxLength(200)]
    public string Nombre { get; set; } = string.Empty;

    [Range(0.01, 9999999)]
    public decimal Precio { get; set; }

    [Range(0, 99)]
    public int EdadRecomendada { get; set; }

    [Range(1, int.MaxValue)]
    public int TematicaId { get; set; }
}
