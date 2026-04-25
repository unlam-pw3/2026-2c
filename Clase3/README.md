# Clase3 - Guia completa del proyecto

Este repositorio es una app ASP.NET Core MVC separada en **3 capas**:

1. **Clase3.Entidad**: modelos de dominio.
2. **Clase3.Servicio**: logica de negocio y almacenamiento en memoria.
3. **Clase3.MVC**: capa web (controladores, vistas, wwwroot).

## Estructura general

```text
Clase3/
|- Clase3.slnx
|- Clase3.Entidad/
|- Clase3.Servicio/
`- Clase3.MVC/
```

## Tecnologias

- .NET 10 (`net10.0`)
- ASP.NET Core MVC
- Bootstrap + jQuery (archivos en `wwwroot/lib`)
- Sin base de datos (usa lista en memoria)

## Flujo funcional actual

### 1) Inicio de la app

En `Clase3.MVC/Program.cs`:

- Registra MVC.
- Registra `IHerramientaServicio` como `Singleton`.
- Define ruta por defecto a `Herramientas/Index`.

### 2) Carga de datos

En `Clase3.Servicio/HerramientaServicio.cs`:

- Se inicializa una lista estatica de `Herramienta`.
- Arranca con 2 herramientas precargadas.
- `AgregarHerramienta` asigna ID incremental y construye ruta de imagen.
- `EditarHerramienta` actualiza descripcion, precio e imagen por `Id`.
- `EliminarHerramienta` elimina por ID.

### 3) Capa web

En `Clase3.MVC/Controllers/HerramientasController.cs`:

- `Index()`: lista herramientas.
- `Crear()` GET: muestra formulario.
- `Crear(Herramienta)` POST: guarda y redirige a listado.
- `Editar(int id)` GET: carga la herramienta a editar.
- `Editar(Herramienta)` POST: guarda cambios y redirige.
- `Eliminar(int id)` GET: elimina y redirige.

### 4) Render en vistas

- `Views/Herramientas/Index.cshtml`: tabla con descripcion, precio, imagen y botones eliminar/editar.
- `Views/Herramientas/Crear.cshtml`: form simple de alta.
- `Views/Herramientas/Editar.cshtml`: form de edicion con `Id` oculto.

## Rutas importantes

- `/Herramientas/Index` (home real de la app)
- `/Herramientas/Crear`
- `/Herramientas/Editar/{id}`
- `/Herramientas/Eliminar/{id}`
- `/Home/Index` y `/Home/Privacy` (plantilla base)

## Archivos estaticos

- Carpeta: `Clase3.MVC/wwwroot`
- Imagenes: `wwwroot/imagenes`
  - `martillo.jpg`
  - `destornillador.jpg`
  - `taladro.jpg`
  - `picodeloro.jpg`
  - `sinimagen.jpg`

## Estado del CRUD

- **Create**: implementado
- **Read**: implementado
- **Delete**: implementado
- **Update (Editar)**: implementado

## Comportamiento actual de Editar

1. En vista de edicion se envian `Descripcion` y `Precio` con valor actual, y `Imagen` como `placeholder`.
2. Si `Imagen` queda vacia, no se sobrescribe la imagen previa.
3. Si `Imagen` tiene texto, se guarda como `\imagenes\{nombre}.jpg`.

## Notas tecnicas observadas

- El servicio usa una lista estatica en memoria: al reiniciar app, se pierden altas.
- La ruta de imagen se arma con barra invertida (`\`) en servicio.
- El fallback en alta usa `sinimagen.jpg`.
- El ingreso de imagen hoy es texto (no `input file`), por lo que no hay carga de archivos nuevos desde el front.

## Como ejecutar

Desde `Clase3/`:

```powershell
dotnet run --project .\Clase3.MVC\Clase3.MVC.csproj
```

Puertos declarados en `launchSettings.json`:

- `http://localhost:5005`
- `https://localhost:7092`
