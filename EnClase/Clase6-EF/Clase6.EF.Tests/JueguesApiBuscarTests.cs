using global::Clase6.EF.Api.Controllers;
using global::Clase6.EF.Api.Dto;
using global::Clase6.EF.Api.Dtos;
using global::Clase6.EF.Entidades;
using global::Clase6.EF.Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clase6.EF.Tests;

public class JueguesApiBuscarTests
{
    [Fact]
    public void Buscar_FiltraPorNombre_YOrdenaPorPrecioDesc()
    {
        var db = CrearContexto();

        var controller = new JuguetesController(new JuguetesLogica(db));
        var query = new JugueteQueryDto
        {
            Nombre = "Robot",
            SortBy = "precio",
            SortDir = "desc",
            Page = 1,
            PageSize = 10
        };

        var action = controller.Get(query);

        var ok = Assert.IsType<OkObjectResult>(action.Result);
        var payload = Assert.IsType<PagedResultDto<JugueteListItemDto>>(ok.Value);

        Assert.Equal(2, payload.TotalCount);
        Assert.Equal(2, payload.Items.Count);
        Assert.Equal("Robot Pro", payload.Items[0].Nombre); // más caro primero
        Assert.Equal("Robot Mini", payload.Items[1].Nombre);
    }

    [Fact]
    public void Buscar_PaginaCorrectamente()
    {
        var db = CrearContexto();

        var controller = new JuguetesController(new JuguetesLogica(db));
        var query = new JugueteQueryDto
        {
            SortBy = "id",
            SortDir = "asc",
            Page = 12,
            PageSize = 2
        };

        var action = controller.Get(query);

        var ok = Assert.IsType<OkObjectResult>(action.Result);
        var payload = Assert.IsType<PagedResultDto<JugueteListItemDto>>(ok.Value);

        Assert.Equal(25, payload.TotalCount);
        Assert.Equal(13, payload.TotalPages);
        Assert.Equal(2, payload.Items.Count);
        Assert.Equal("Auto", payload.Items[0].Nombre);
        Assert.Equal("Bloques", payload.Items[1].Nombre);
    }

    [Fact]
    public void Buscar_NormalizaPageYPageSizeInvalidos()
    {
        var db = CrearContexto();

        var controller = new JuguetesController(new JuguetesLogica(db));
        var query = new JugueteQueryDto
        {
            Page = 0,
            PageSize = 0
        };

        var action = controller.Get(query);

        var ok = Assert.IsType<OkObjectResult>(action.Result);
        var payload = Assert.IsType<PagedResultDto<JugueteListItemDto>>(ok.Value);

        Assert.Equal(1, payload.Page);
        Assert.Equal(10, payload.PageSize);
        Assert.Equal(25, payload.TotalCount);
    }

    private static JugueteriaDbContext CrearContexto()
    {
        var db = Contexto.CrearContexto();
        Contexto.LlenarBaseDeDatosConRegistros(db, 20);
        Seed(db);
        return db;
    }

    private static void Seed(JugueteriaDbContext db)
    {
        db.Juguetes.AddRange(
            new Juguete { Nombre = "Robot Mini", Precio = 1000, EdadRecomendada = 6, TematicaId = 1 },
            new Juguete { Nombre = "Robot Pro", Precio = 5000, EdadRecomendada = 8, TematicaId = 1 },
            new Juguete { Nombre = "Auto", Precio = 800, EdadRecomendada = 5, TematicaId = 1 },
            new Juguete { Nombre = "Bloques", Precio = 1200, EdadRecomendada = 4, TematicaId = 2 },
            new Juguete { Nombre = "Tren", Precio = 1500, EdadRecomendada = 7, TematicaId = 2 }
        );

        db.SaveChanges();
    }
}