using Clase6.EF.Logica;
using Clase6.EF.Tests;

namespace Clase6.EF.Tests;


public class JueguesApiGetTests
{
    [Fact]
    public void ObtenerPaginado_Page2_Size10_Devuelve10ItemsYTotalCorrecto()
    {
        using var context = Contexto.CrearContexto();
        Contexto.LlenarBaseDeDatosConRegistros(context, 25);
        var logica = new JuguetesLogica(context);

        var (items, totalCount) = logica.ObtenerPaginado(2, 10);

        Assert.Equal(25, totalCount);
        Assert.Equal(10, items.Count());
        Assert.Equal("Juguete 11", items.First().Nombre);
    }

    [Fact]
    public void ObtenerPaginado_Page3_Size10_DevuelveResto()
    {
        using var context = Contexto.CrearContexto();
        Contexto.LlenarBaseDeDatosConRegistros(context, 25);
        var logica = new JuguetesLogica(context);

        var (items, totalCount) = logica.ObtenerPaginado(3, 10);

        Assert.Equal(25, totalCount);
        Assert.Equal(5, items.Count());
        Assert.Equal("Juguete 21", items.First().Nombre);
    }

    [Fact]
    public void ObtenerPaginado_PaginaFueraDeRango_DevuelveVacio()
    {
        using var context = Contexto.CrearContexto();
        Contexto.LlenarBaseDeDatosConRegistros(context, 12);
        var logica = new JuguetesLogica(context);

        var (items, totalCount) = logica.ObtenerPaginado(5, 10);

        Assert.Equal(12, totalCount);
        Assert.Empty(items);
    }
}
