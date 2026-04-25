# Clase3.Entidad

Proyecto de **entidades de dominio** compartidas por Servicio y MVC.

## Archivo principal

- `Herramienta.cs`

## Modelo `Herramienta`

Propiedades:

- `Id` (`int`)
- `Descripcion` (`string`)
- `Precio` (`decimal`)
- `Imagen` (`string`)

## Rol en la solucion

- Define el contrato de datos base de la ferreteria.
- Evita duplicar modelos entre capas.
- Se referencia desde:
  - `Clase3.Servicio` (logica)
  - `Clase3.MVC` (binding y vistas)
