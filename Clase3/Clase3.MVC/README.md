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
- `Eliminar` (GET): elimina por ID y redirige a `Index`.

### `HomeController`

Controlador de plantilla (Home/Privacy/Error), secundario para este ejercicio.

## Vistas

- `Views/Herramientas/Index.cshtml`
  - Tabla principal.
  - Muestra imagen con `<img src="@herramienta.Imagen" ... />`.
  - Acciones: Crear y Eliminar.
- `Views/Herramientas/Crear.cshtml`
  - Formulario manual (sin `asp-for`).
- `Views/Shared/_Layout.cshtml`
  - Layout comun y carga de Bootstrap/jQuery.

## Assets estaticos

- `wwwroot/css/site.css`
- `wwwroot/js/site.js`
- `wwwroot/imagenes/*.jpg`

## Flujo HTTP actual (CRUD parcial)

1. Navegar a `/Herramientas/Index`
2. Click en "Crear Herramienta" -> `/Herramientas/Crear` (GET)
3. Enviar formulario -> `/Herramientas/Crear` (POST)
4. Volver a listado con nueva fila
5. Click en "Eliminar" -> `/Herramientas/Eliminar/{id}` (GET)

## Para implementar Editar (tarea)

Necesitas agregar:

1. Accion GET para cargar datos.
2. Accion POST para guardar cambios.
3. Vista `Editar.cshtml`.
4. Boton/enlace "Editar" en listado.

Tip: reutiliza `BuscarHerramientaPorId` y concentra la normalizacion de imagen en el servicio.
