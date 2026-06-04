using Clase6.EF.Entidades;
using Clase6.EF.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Clase6.EF.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FabricantesController : ControllerBase
{
    //di
    private readonly IFabricantesLogica _fabricantesLogica;
    public FabricantesController(IFabricantesLogica fabricantesLogica)
    {
        _fabricantesLogica = fabricantesLogica;
    }

    [HttpGet]
    [SwaggerOperation(
        Summary = "Obtener todos los fabricantes",
        Description = "Devuelve una lista de todos los fabricantes disponibles"
        )]
    [ProducesResponseType(typeof(List<Fabricante>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var fabricantes = _fabricantesLogica.ObtenerTodos();
        return Ok(fabricantes);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(
    Summary = "Obtener fabricante por ID",
    Description = "Devuelve un fabricante específico según su ID"
    )]
    [ProducesResponseType(typeof(Fabricante), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var fabricante = _fabricantesLogica.ObtenerPorId(id);
        if (fabricante == null)
            return NotFound();
        return Ok(fabricante);
    }
}