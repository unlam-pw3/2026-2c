using Microsoft.AspNetCore.Mvc;
using TareaMVC.Logica;
using TareaMVC.Entidades;

namespace TareaMVC.Web.Controllers;

public class AutomovilesController : Controller
{
    private readonly IAutomovilesServicios _automovilesServicios;

    public AutomovilesController(IAutomovilesServicios automovilServicios)
    {
        _automovilesServicios = automovilServicios;
    }

    public IActionResult Index()
    {
        var automoviles = _automovilesServicios.ObtenerTodos();
        return View(automoviles);
    }

    public IActionResult Detalles(int id)
    {
        var automovil = _automovilesServicios.ObtenerPorId(id);
        if (automovil == null)
        {
            return NotFound();
        }
        return View(automovil);
    }

    public IActionResult Agregar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Agregar(Automovil automovil)
    {
        if (ModelState.IsValid)
        {
            _automovilesServicios.Agregar(automovil);
            return RedirectToAction(nameof(Index));
        }
        return View(automovil);
    }

    public IActionResult Actualizar(int id)
    {
        var automovil = _automovilesServicios.ObtenerPorId(id);
        if (automovil == null)
        {
            return NotFound();
        }
        return View(automovil);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Actualizar(int id, Automovil automovil)
    {
        if (id != automovil.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _automovilesServicios.Actualizar(automovil);
            return RedirectToAction(nameof(Index));
        }
        return View(automovil);
    }

    public IActionResult Eliminar(int id)
    {
        var automovil = _automovilesServicios.ObtenerPorId(id);
        if (automovil == null)
        {
            return NotFound();
        }
        return View(automovil);
    }

    [HttpPost, ActionName("Eliminar")]
    [ValidateAntiForgeryToken]
    public IActionResult EliminarConfirmado(int id)
    {
        _automovilesServicios.Eliminar(id);
        return RedirectToAction(nameof(Index));
    }
}