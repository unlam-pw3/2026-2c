# Clase2.API_Licencias

## Descripción

API ASP.NET Core de la solución de Clase 2.
Expone endpoints para dos recursos: `Licencias` y `Empleados`.

## Controladores

- `LicenciasController`
  - registra licencias.
  - lista licencias registradas.
- `EmpleadosController`
  - registra empleados.
  - lista empleados.

## Endpoints

- `POST /api/licencias`
- `GET /api/licencias`
- `POST /api/empleados`
- `GET /api/empleados`

## Inyección de dependencias

En `Program.cs` se registran como `Singleton`:

- `ILicenciaService -> LicenciaService`
- `IEmpleadoService -> EmpleadoService`

La persistencia es en memoria (listas en servicios).

## Swagger

Swagger está habilitado en entorno de desarrollo.

Ruta habitual:

- `https://localhost:{puerto}/swagger`

## Dependencias principales

- `Swashbuckle.AspNetCore`
- `Clase2.Servicio`

