# Clase 5 — Práctica MVC - Validaciones - Pasaje de datos

Resumen
- Aplicación de ejemplo para practicar ASP.NET Core MVC (Razor Views) con el modelo `Animal`.
- Temas: `ViewBag`, `TempData`, validaciones con DataAnnotations y extensión del modelo.
Qué se vio en clase
- `ViewBag`: pasar datos simples desde el controlador a la vista (ej.: `ViewBag.NacimientosUltimoMes`).
- `TempData`: pasar mensajes entre requests (ej.: mostrar aleatoriamente un aviso en `Index`).
- Validaciones: atributos en el modelo (`[Required]`, `[Range]`, `[StringLength]`) y uso de `ModelState.IsValid` en POST.
- Manejo correcto de `checkbox` en formularios (input hidden + checkbox o `asp-for`).

Tarea (entregar)
1) ViewBag
  - En `AnimalesController.GET Agregar` setear `ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);`.
  - En la vista `Agregar` mostrar ese número en un panel informativo.

2) TempData
  - En `AnimalesController.Index` generar aleatoriamente (ej. 30% de probabilidad) un mensaje:
    `TempData["Alerta"] = $"Durante el último año la raza {raza} redujo su población en {porcentaje}%";`
  - En la vista `Index` mostrar `TempData["Alerta"]` si existe (alert Bootstrap), se debe consumir en la siguiente petición.

3) Validaciones
  - Usar `DataAnnotations` en `ClaseMVC.Entidades\Animal`.
  - En los métodos `POST` de `Agregar`/`Editar` comprobar `ModelState.IsValid`. Si no es válido, reasignar `ViewBag` y `return View(model)` para mostrar errores.

4) Nuevos campos simples para `Animal`
  - Sugeridos (añadir en `ClaseMVC.Entidades\Animal`):
    - `public string Habitat { get; set; }` — `[Required, StringLength(200)]`
    - `public double? Largo { get; set; }` — `[Range(0.01, 1000)]` (metros) — opcional (`double?`)
    - `public string SignificadoNombre { get; set; }` — `[StringLength(500)]`
  - Actualizar vistas `Agregar`/`Editar` para incluirlos y `AnimalesServicios` con datos de ejemplo.

Criterios de aceptación
- `Agregar` muestra `ViewBag.NacimientosUltimoMes` en la vista.
- `Index` puede mostrar aleatoriamente `TempData["Alerta"]` y este desaparece al recargar.
- Las validaciones se muestran en las vistas y el `ModelState` evita persistir datos inválidos.
- La aplicación compila y los servicios de ejemplo contienen valores para los nuevos campos.

Snippets útiles
- Pasar ViewBag en controller:
```csharp
ViewBag.NacimientosUltimoMes = new Random().Next(0, 20);
```
- Generar TempData en `Index`:
```csharp
if (new Random().NextDouble() < 0.3)
{
    var raza = "Tigre"; // ejemplo o elegir desde la lista
    var porcentaje = new Random().Next(1, 50);
    TempData["Alerta"] = $"Durante el último año la raza {raza} redujo su población en {porcentaje}%";
}
```
- Checkbox en la vista (tag helper):
```html
<input asp-for="EnExtincion" class="form-check-input" />
```

Notas
- Para formularios más complejos se recomienda crear un ViewModel fuertemente tipado en lugar de usar `ViewBag`.
- Si quieres, puedo aplicar los cambios sugeridos (añadir propiedades en `Animal.cs`, actualizar vistas y `AnimalesServicios`).


# Clase 4 - MVC - Animales C#

## Descripción

Esta solución contiene la implementación de un ABM de Animales usando MVC y capas de Entidades y Logica

## Tarea

**Utilizar el ejemplo de la clase anterior que ya tenemos en sharepoint, y agregarle el proyecto MVC, ya que tenemos entidades y servicios implementados.

## Intrucciones
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original
---

¡Buena suerte con la nueva tarea!