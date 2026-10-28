using Clase6.EF.Api.Dto;
using Clase6.EF.Api.Dtos;
using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JuguetesController : ControllerBase
{
    private readonly IJuguetesLogica _juguetesLogica;

    public JuguetesController(IJuguetesLogica juguetesLogica)
    {
        _juguetesLogica = juguetesLogica;
    }

    [HttpGet]
    public ActionResult<PagedResultDto<JugueteListItemDto>> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var (items, totalCount) = _juguetesLogica.ObtenerPaginado(page, pageSize);

        var result = new PagedResultDto<JugueteListItemDto>
        {
            Page = page < 1 ? 1 : page,
            PageSize = pageSize < 1 ? 10 : (pageSize > 100 ? 100 : pageSize),
            TotalCount = totalCount,
            TotalPages = (int)Math.Ceiling(totalCount / (double)(pageSize < 1 ? 10 : (pageSize > 100 ? 100 : pageSize))),
            Items = items.Select(j => new JugueteListItemDto
            {
                Id = j.Id,
                Nombre = j.Nombre,
                Precio = j.Precio,
                EdadRecomendada = j.EdadRecomendada,
                TematicaId = j.TematicaId,
                TematicaNombre = j.Tematica?.Nombre
            }).ToList()
        };

        return Ok(result);
    }

    [HttpPost]
    public ActionResult<JugueteListItemDto> Post([FromBody] JugueteCrearDto dto)
    {
        var juguete = new Juguete
        {
            Nombre = dto.Nombre,
            Precio = dto.Precio,
            EdadRecomendada = dto.EdadRecomendada,
            TematicaId = dto.TematicaId
        };

        _juguetesLogica.Agregar(juguete);

        var result = new JugueteListItemDto
        {
            Id = juguete.Id,
            Nombre = juguete.Nombre,
            Precio = juguete.Precio,
            EdadRecomendada = juguete.EdadRecomendada,
            TematicaId = juguete.TematicaId
        };

        return Created($"/api/juguetes/{juguete.Id}", result);
    }
}