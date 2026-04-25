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
- `EditarHerramienta(Herramienta herramienta)`
- `EliminarHerramienta(int id)`

### `HerramientaServicio`

Implementacion concreta registrada como `Singleton` en MVC.

Responsabilidades:

- Inicializar lista estatica con herramientas semilla.
- Asignar ID incremental al crear.
- Normalizar campo `Imagen` al crear.
- Buscar por ID.
- Editar por ID (actualizacion parcial de campos).
- Eliminar por ID.

## Comportamiento actual a tener en cuenta

- Al ser lista en memoria, no persiste al reiniciar la app.
- Construye rutas de imagen con `\imagenes\...` y agrega `.jpg` en alta/edicion.
- El fallback en alta usa `\imagenes\sinimagen.jpg`.
- En edicion:
  - Si `Descripcion` viene `null`, mantiene el valor anterior.
  - Si `Precio` viene `0`, mantiene el valor anterior.
  - Si `Imagen` viene vacia, mantiene la imagen anterior.

Estos puntos impactan directamente la visualizacion de imagenes en la capa MVC.
