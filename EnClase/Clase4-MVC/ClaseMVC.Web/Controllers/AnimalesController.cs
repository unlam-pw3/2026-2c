using System.Diagnostics;
using ClaseMVC.Entidades;
using ClaseMVC.Logica;
using ClaseMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClaseMVC.Web.Controllers;

public class AnimalesController : Controller
{
    private readonly IAnimalesServicios _animalesServicios;
    public AnimalesController(IAnimalesServicios animalesServicios)
    {
        _animalesServicios = animalesServicios;
    }

    public IActionResult Index()
    {
        var animales = _animalesServicios.Listar();
        if (new Random().NextDouble() < 0.3)
        {
            var random = new Random();
            var animalAleatorio = animales[random.Next(animales.Count)];
            var raza = animalAleatorio.Raza; 
            var porcentaje = random.Next(1, 50);

            TempData["Alerta"] = $"Durante el último año la raza {raza} redujo su población en {porcentaje}%";
        }
        return View(animales);
    }

    //Agregar


    [HttpGet]
    public IActionResult Agregar()
    {
        ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);
        return View(new Animal());
    }

    [HttpPost]
    public IActionResult Agregar(Animal animal)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);
            return View(animal);
        }
        _animalesServicios.Agregar(animal);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var animal = _animalesServicios.ObtenerPorId(id);

        if (animal == null)
        {
            return NotFound();
        }
        //viewbag
        //viewdata
        //tempdata --> tiempo de vida + 1 request (1 redirect)

        //mock de datos
        //datos actualizados de una api de cuantos ejemplares quedan a nivel mundial

        ViewBag.CantidadEjemplares = new Random().Next(2500);
        ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);
        //ViewData["CantidadEjemplares"] = new Random().Next(2500);
        //TempData["CantidadEjemplares"] = new Random().Next(2500);

        return View(animal);
    }

    [HttpPost]
    public IActionResult Editar(Animal animal)
    {
        var animalDB = _animalesServicios.ObtenerPorId(animal.Id);
        if (animalDB == null)
            return NotFound();
        if (ModelState.IsValid) { 
        _animalesServicios.Actualizar(animal);
        return RedirectToAction("Index");
        }
        ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);
        return View(animal);
    }

    [HttpGet]
    public IActionResult Eliminar(int id)
    {
        var animal = _animalesServicios.ObtenerPorId(id);
        if (animal == null)
        {
            return NotFound();
        }
        TempData["Mensaje"] = $"El animal {animal.Raza} ha sido eliminado correctamente.";

        _animalesServicios.Eliminar(id);

        return RedirectToAction("Index");
    }
}
