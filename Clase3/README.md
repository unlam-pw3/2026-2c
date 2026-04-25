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
- `EliminarHerramienta` elimina por ID.

### 3) Capa web

En `Clase3.MVC/Controllers/HerramientasController.cs`:

- `Index()`: lista herramientas.
- `Crear()` GET: muestra formulario.
- `Crear(Herramienta)` POST: guarda y redirige a listado.
- `Eliminar(int id)` GET: elimina y redirige.

### 4) Render en vistas

- `Views/Herramientas/Index.cshtml`: tabla con descripcion, precio, imagen y boton eliminar.
- `Views/Herramientas/Crear.cshtml`: form simple de alta.

## Rutas importantes

- `/Herramientas/Index` (home real de la app)
- `/Herramientas/Crear`
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
- **Update (Editar)**: pendiente (tu tarea)

## Guia rapida para implementar "Editar"

1. En servicio:
   - Agregar metodo para actualizar una herramienta existente por `Id`.
2. En controlador:
   - `Editar(int id)` GET para cargar datos al formulario.
   - `Editar(Herramienta herramienta)` POST para persistir cambios.
3. En vistas:
   - Crear `Views/Herramientas/Editar.cshtml`.
   - Agregar boton "Editar" en `Index.cshtml`.
4. Mantener consistencia de imagen:
   - Definir si el campo recibira nombre (`martillo`) o ruta completa (`/imagenes/martillo.jpg`) y normalizar en un solo lugar (servicio).

## Notas tecnicas observadas

- El servicio usa una lista estatica en memoria: al reiniciar app, se pierden altas.
- La ruta de imagen se arma con barra invertida (`\`) en servicio; para URL web conviene barra normal (`/`).
- En fallback se usa `default.jpg`, pero en `wwwroot/imagenes` existe `sinimagen.jpg`.

## Como ejecutar

Desde `Clase3/`:

```powershell
dotnet run --project .\Clase3.MVC\Clase3.MVC.csproj
```

Puertos declarados en `launchSettings.json`:

- `http://localhost:5005`
- `https://localhost:7092`
