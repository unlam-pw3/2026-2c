using System.Diagnostics;
using ClaseMVC.Entidades;
using ClaseMVC.Logica;
using ClaseMVC.Logica.Exceptions;
using ClaseMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClaseMVC.Web.Controllers;

public class AnimalesController : Controller
{
    private readonly IAnimalesServicios _animalesServicios;
    private readonly IWebHostEnvironment _env;
    public AnimalesController(IAnimalesServicios animalesServicios, IWebHostEnvironment env)
    {
        _animalesServicios = animalesServicios;
        _env = env;
    }

    public IActionResult Index()
    {
        var animales = _animalesServicios.Listar();

        return View(animales);
    }

    //Agregar


    [HttpGet]
    public IActionResult Agregar()
    {
        return View(new Animal());
    }

    [HttpPost]
    public IActionResult Agregar(Animal animal, IFormFile archivoFoto)
    {
        if (archivoFoto == null || archivoFoto.Length == 0)
        {
            ModelState.AddModelError("archivoFoto", "Debe adjuntar una imagen.");
            return View(animal);
        }
        try
        {
            string ruta = Path.Combine(_env.WebRootPath, "img");
            using (var flujoOrigen = archivoFoto.OpenReadStream())
            {
            _animalesServicios.RegistrarAnimal(animal, archivoFoto.FileName, flujoOrigen, ruta);
            }

  
            return RedirectToAction("Index");
        }
        catch(ValidacionImagenException e)
        {
            ModelState.Remove("archivoFoto");
            ModelState.AddModelError("archivoFoto", e.Message);
            return View(animal);

        }
    }

 
   

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var animal = _animalesServicios.ObtenerPorId(id);

        if (animal == null)
        {
            return NotFound();
        }

        return View(animal);
    }

    [HttpPost]
    public IActionResult Editar(Animal animal)
    {
        var animalDB = _animalesServicios.ObtenerPorId(animal.Id);
        if (animalDB == null)
            return NotFound();

        _animalesServicios.Actualizar(animal);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Eliminar(int id)
    {
        var animal = _animalesServicios.ObtenerPorId(id);
        if (animal == null)
        {
            return NotFound();
        }

        _animalesServicios.Eliminar(id);

        return RedirectToAction("Index");
    }
}
