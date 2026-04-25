# Clase3.MVC

Proyecto web ASP.NET Core MVC de la aplicacion de ferreteria.

## Entrada y configuracion

- `Program.cs`
  - Agrega MVC (`AddControllersWithViews`).
  - Inyecta `IHerramientaServicio` como `Singleton`.
  - Configura ruta por defecto: `Herramientas/Index`.

## Controladores

### `HerramientasController`

- `Index` (GET): lista herramientas.
- `Crear` (GET): renderiza formulario.
- `Crear` (POST): agrega herramienta y redirige a `Index`.
- `Editar` (GET): busca por `id` y carga el formulario de edicion.
- `Editar` (POST): actualiza la herramienta y redirige a `Index`.
- `Eliminar` (GET): elimina por ID y redirige a `Index`.

### `HomeController`

Controlador de plantilla (Home/Privacy/Error), secundario para este ejercicio.

## Vistas

- `Views/Herramientas/Index.cshtml`
  - Tabla principal.
  - Muestra imagen con `<img src="@herramienta.Imagen" ... />`.
  - Acciones: Crear, Eliminar y Editar.
- `Views/Herramientas/Crear.cshtml`
  - Formulario manual (sin `asp-for`).
- `Views/Herramientas/Editar.cshtml`
  - Vista tipada con `@model Herramienta`.
  - Envia `Id` oculto para ubicar el registro a modificar.
  - Usa `placeholder` en `Imagen` para mantener la ruta actual si no se cambia.
- `Views/Shared/_Layout.cshtml`
  - Layout comun y carga de Bootstrap/jQuery.

## Assets estaticos

- `wwwroot/css/site.css`
- `wwwroot/js/site.js`
- `wwwroot/imagenes/*.jpg`

## Flujo HTTP actual (CRUD)

1. Navegar a `/Herramientas/Index`
2. Click en "Crear Herramienta" -> `/Herramientas/Crear` (GET)
3. Enviar formulario -> `/Herramientas/Crear` (POST)
4. Volver a listado con nueva fila
5. Click en "Editar" -> `/Herramientas/Editar/{id}` (GET)
6. Enviar edicion -> `/Herramientas/Editar` (POST)
7. Click en "Eliminar" -> `/Herramientas/Eliminar/{id}` (GET)
