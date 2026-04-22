# Clase2.FrontForm

## Descripción

Aplicación WinForms para operar licencias y empleados desde interfaz gráfica.

## Funcionalidad implementada

- Registro de empleados (`Nombre`, `DNI`, `Correo`, `Departamento`).
- Consulta de empleados desde API para carga dinámica de combo.
- Registro de licencias usando empleado seleccionado desde combo.
- Consulta de licencias para visualizar en grilla.

## Carga dinámica en runtime

La carga dinámica requerida por la tarea se resuelve así:

1. Botón **Cargar Empleados** ejecuta consulta a `GET /api/empleados`.
2. Se limpia y recarga el `ComboBox` de empleados con lo recibido del API.
3. Al registrar licencia, se toma el empleado seleccionado del combo.

## Integración

El front consume `Clase2.API_Licencias` por HTTP/HTTPS.
Para funcionar correctamente, la API debe estar iniciada antes de abrir este proyecto.

## Proyecto referenciado

- `Clase2.Entidad`

