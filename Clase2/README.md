# Clase 2 - Sistema de Licencias

## Contexto

Este módulo fue desarrollado en clase por el profesor.
Mi trabajo en este repositorio fue pasarlo y adaptarlo a `.NET 10` para poder ejecutarlo en mi entorno.

## Arquitectura

La solución está separada en capas/proyectos:

- `Clase2.Entidad`: modelo de datos compartido (`Licencia`).
- `Clase2.Servicio`: lógica de negocio básica en memoria (`ILicenciaService`, `LicenciaService`).
- `Clase2.API_Licencias`: API ASP.NET Core con endpoints para registrar y listar licencias.
- `Clase2.FrontForm`: aplicación WinForms que consume la API.

## Flujo general

1. El usuario carga datos en el formulario WinForms.
2. El front envía o consulta datos contra la API.
3. La API delega en `LicenciaService`.
4. El servicio guarda/retorna datos en memoria.

## Ejecución

1. Iniciar `Clase2.API_Licencias`.
2. Verificar que la API quede escuchando en los puertos configurados.
3. Iniciar `Clase2.FrontForm`.
4. Desde el front, usar **Registrar** y **Consultar**.

## Endpoints

- `POST /api/licencias`
- `GET /api/licencias`

