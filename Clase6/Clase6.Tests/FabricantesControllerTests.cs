using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Clase6.Tests;

public class FabricantesControllerTests :
IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public FabricantesControllerTests(
        WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetFabricantes_ReturnsOk()
    {
        var response =
            await _client.GetAsync("/api/fabricantes");

        Assert.Equal(
            HttpStatusCode.OK,
            response.StatusCode);
    }

    [Fact]
    public async Task GetFabricanteById_ReturnsOk()
    {
        var response =
            await _client.GetAsync("/api/fabricantes/1");

        Assert.Equal(
            HttpStatusCode.OK,
            response.StatusCode);
    }
}