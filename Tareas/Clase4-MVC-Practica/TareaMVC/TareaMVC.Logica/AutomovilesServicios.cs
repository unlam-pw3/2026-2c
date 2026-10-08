using TareaMVC.Entidades;

namespace TareaMVC.Logica;

public interface IAutomovilesServicios
{
    List<Automovil> ObtenerTodos();
    Automovil ObtenerPorId(int id);
    void Agregar(Automovil automovil);
    void Actualizar(Automovil automovil);
    void Eliminar(int id);
}

public class AutomovilesServicios : IAutomovilesServicios
{
    private static List<Automovil> automoviles;
    public AutomovilesServicios()
    {
        automoviles = new List<Automovil>
        {
            new Automovil { Id = 1, Marca = "Toyota", Modelo = "Corolla", Anio = 2020, EsNuevo = true },
            new Automovil { Id = 2, Marca = "Honda", Modelo = "Civic", Anio = 2019, EsNuevo = false },
            new Automovil { Id = 3, Marca = "Ford", Modelo = "Focus", Anio = 2021, EsNuevo = true }
        };
    }

    public List<Automovil> ObtenerTodos()
    {
        return automoviles;
    }

    public Automovil ObtenerPorId(int id)
    {
        return automoviles.FirstOrDefault(a => a.Id == id);
    }

    public void Agregar(Automovil automovil)
    {
        automovil.Id = automoviles.Count == 0 ? 1 : automoviles.Max(a => a.Id) + 1;
        automoviles.Add(automovil);
    }

    public void Actualizar(Automovil automovil)
    {
        var automovilExistente = ObtenerPorId(automovil.Id);
        if (automovilExistente != null)
        {
            automovilExistente.Marca = automovil.Marca;
            automovilExistente.Modelo = automovil.Modelo;
            automovilExistente.Anio = automovil.Anio;
            automovilExistente.EsNuevo = automovil.EsNuevo;
        }
    }

    public void Eliminar(int id)
    {
        var automovil = ObtenerPorId(id);
        if (automovil != null)
        {
            automoviles.Remove(automovil);
        }
    }
}