using ClaseMVC.Entidades;
using ClaseMVC.Logica.Exceptions;

namespace ClaseMVC.Logica;

public interface IAnimalesServicios
{
    void Actualizar(Animal animal);
    List<Animal> Listar();
    Animal? ObtenerPorId(int id);
    public void RegistrarAnimal(Animal animal, string nombreArchivoOriginal, Stream stream, string ruta);
  
    void Eliminar(int id);
}
public class AnimalesServicios : IAnimalesServicios
{
    private static List<Animal> lista;

    public AnimalesServicios()
    {
        lista = new List<Animal>()
        {
            new Animal() { Id=1, Raza = "Perro", ImagenUrl="/img/perro.jfif", Peso = 20.5, EdadEstimada = 5, EnExtincion = false },
            new Animal() { Id=2, Raza = "Gato", ImagenUrl="/img/gato.jfif", Peso = 5.0, EdadEstimada = 3, EnExtincion = false },
            new Animal() { Id=3, Raza = "Tigre", ImagenUrl="/img/tigre.jfif", Peso = 200.0, EdadEstimada = 10, EnExtincion = true },
            new Animal() { Id=4, Raza = "Elefante", ImagenUrl="/img/elefante.jfif", Peso = 5000.0, EdadEstimada = 50, EnExtincion = true },
            new Animal() { Id=5, Raza = "Loro", ImagenUrl="/img/loro.jfif", Peso = 1.0, EdadEstimada = 2, EnExtincion = false }
        };
    }

    public void Actualizar(Animal animal)
    {
        var animalDB = lista.Find(a => a.Id == animal.Id);
        if (animalDB != null)
        {
            animalDB.Raza = animal.Raza;
            animalDB.Peso = animal.Peso;
            animalDB.EdadEstimada = animal.EdadEstimada;
            animalDB.EnExtincion = animal.EnExtincion;
        }
    }

   

    public void RegistrarAnimal(Animal animal, string nombreArchivoOriginal, Stream stream, string ruta)
    {
        string extensionOriginal = Path.GetExtension(nombreArchivoOriginal.ToLower());
        ValidarExtension(extensionOriginal);
        string nombreArchivo = Guid.NewGuid().ToString() + extensionOriginal;
        string rutaFinal = Path.Combine(ruta, nombreArchivo);
        GuardarArchivo(stream, rutaFinal);
        Agregar(animal, nombreArchivo);

    }

    public void ValidarExtension(string extensionOriginal)
    {
        string[] extensionesPermitidas = { ".jpg", ".jpeg", ".png", ".webp" };
        if (!extensionesPermitidas.Contains(extensionOriginal))
        {
            throw new ValidacionImagenException("Solo se permiten imágenes (JPG, PNG, JPEG, WEBP)");
        }
    }
    public void GuardarArchivo(Stream stream, string ruta)
    {
        using (var streamDestino = new FileStream(ruta, FileMode.Create))
        {
            stream.CopyTo(streamDestino);
        }
    }

    private void Agregar(Animal animal, string nombreArchivo)
    {
        animal.ImagenUrl = "/img/" + nombreArchivo;
        int nuevoId = lista.Count > 0 ? lista.Max(a => a.Id) + 1 : 1;
        animal.Id = nuevoId;

        lista.Add(animal);
    }


    public void Eliminar(int id)
    {
        var animalDB = lista.Find(a => a.Id == id);
        if (animalDB != null)
        {
            lista.Remove(animalDB);
        }
    }

    /// <summary>
    /// Lista todos los animales en la lista
    /// </summary>
    /// <returns>Una lista de animales</returns>
    public List<Animal> Listar()
    {
        return lista;
    }

    public Animal? ObtenerPorId(int id)
    {
        return lista.Find(animal => animal.Id == id);
    }
}
