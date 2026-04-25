# Clase 2 - Sistema de Licencias

## Contexto

La base funcional de esta clase fue desarrollada por el profesor en clase.
Sobre esa base, en este repositorio se realizó la migración a `.NET 10` y la tarea de extender la solución con una nueva entidad (`Empleado`) integrada con API + WinForms.

## Arquitectura

La solución está separada en capas/proyectos:

- `Clase2.Entidad`: entidades compartidas (`Licencia`, `Empleado`).
- `Clase2.Servicio`: lógica en memoria (`ILicenciaService`, `LicenciaService`, `IEmpleadoService`, `EmpleadoService`).
- `Clase2.API_Licencias`: API ASP.NET Core con endpoints para licencias y empleados.
- `Clase2.FrontForm`: aplicación WinForms que consume la API.

## Qué se implementó en la tarea

1. Se agregó la entidad `Empleado` con campos `Nombre`, `Dni`, `Correo` y `Departamento`.
2. Se incorporó servicio de empleados en la capa `Clase2.Servicio`.
3. Se creó `EmpleadosController` para registrar y listar empleados.
4. En WinForms se agregó sección para registrar empleados.
5. Se agregó botón para cargar empleados desde API en tiempo de ejecución.
6. El `ComboBox` de empleados se llena dinámicamente desde `GET /api/empleados`.
7. El registro de licencia ahora toma el empleado seleccionado del combo dinámico.

## Flujo general actual

1. Se registra un empleado desde WinForms (`POST /api/empleados`).
2. Se cargan empleados con el botón de consulta (`GET /api/empleados`) y se completa el combo.
3. Se registra una licencia usando un empleado seleccionado del combo (`POST /api/licencias`).
4. Se consultan licencias para mostrarlas en grilla (`GET /api/licencias`).

## Ejecución

1. Iniciar `Clase2.API_Licencias`.
2. Verificar puertos activos (por defecto `https://localhost:7044` y `http://localhost:5157`).
3. Iniciar `Clase2.FrontForm`.
4. Usar botones de registro y consulta desde la interfaz.

## Endpoints disponibles

- `POST /api/licencias`
- `GET /api/licencias`
- `POST /api/empleados`
- `GET /api/empleados`

