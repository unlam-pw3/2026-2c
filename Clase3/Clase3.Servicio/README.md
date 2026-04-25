# Clase3.Servicio

Proyecto de **logica de negocio** y almacenamiento en memoria para herramientas.

## Archivo principal

- `HerramientaServicio.cs`

## Componentes

### `IHerramientaServicio`

Define operaciones del dominio:

- `ObtenerHerramientas()`
- `AgregarHerramienta(Herramienta herramienta)`
- `BuscarHerramientaPorId(int id)`
- `EliminarHerramienta(int id)`

### `HerramientaServicio`

Implementacion concreta registrada como `Singleton` en MVC.

Responsabilidades:

- Inicializar lista estatica con herramientas semilla.
- Asignar ID incremental al crear.
- Normalizar campo `Imagen` al crear.
- Buscar por ID.
- Eliminar por ID.

## Comportamiento actual a tener en cuenta

- Al ser lista en memoria, no persiste al reiniciar la app.
- Construye rutas de imagen con `\imagenes\...` y agrega `.jpg` al alta.
- El fallback usa `default.jpg`.

Estos puntos impactan directamente la visualizacion de imagenes en la capa MVC.
