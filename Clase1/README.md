# Clase1 - Introduccion a Visual Studio y C# - Ahorcado

Resumen
-------
Se separó la lógica del juego del ahorcado en componentes testables y reutilizables. Cambios principales:

- `Clase1.Logica/Juego` — `IJuegoAhorcado`, `JuegoAhorcado`: lógica del juego (estado, intentos, adivinar letras).
- `Clase1.Logica/Providers` — `IProveedorPalabras`, `ProveedorPalabrasEstatico`: obtención de palabras (inyectable para tests).
- `Clase1.Logica/IO` — `IConsola`, `ConsolaWrapper`: abstracción de entrada/salida para poder mockear la consola en pruebas.
- `Clase1.Consola/Program.cs` — composición: crea proveedor, consola y juego; ejecuta el bucle de interacción.
- `Clase1.Tests` — pruebas unitarias para `JuegoAhorcado` (cobertura de casos comunes).

Tarea propuesta
---------------

Crear un nuevo juego en este repositorio cuyo objetivo sea adivinar un número entero secreto (por ejemplo entre 1 y 100). En vez de indicar mayor/menor, el juego debe responder con una de estas pistas: `congelado`, `frio`, `tibio`, `caliente`.

Comportamiento esperado (ejemplo de reglas):

- Rango secreto: 1..100.
- Calcular `diff = |secreto - intento|`.
- `congelado` si `diff >= 50`.
- `frio` si `20 <= diff < 50`.
- `tibio` si `5 <= diff < 20`.
- `caliente` si `diff < 5`.

Requisitos mínimos:
- Crear una carpeta Clase-1-Tarea y ahi dentro crear una nueva solucion.
- Separar la lógica del juego en un proyecto o carpeta `JuegoNumero`/`Clase1.Logica.Numero` con una interfaz `IJuegoNumero` y una implementación concreta.
- Añadir abstracciones para IO si hace falta (reutilizar `IConsola`).
- Escribir pruebas unitarias que cubran las reglas de `congelado`/`frio`/`tibio`/`caliente` y los casos de ganar/perder.
- Añadir una implementación en `Program.cs` (o un binario separado) que permita jugar desde la consola.

Instrucciones para entregar
--------------------------

1. Hacer fork de este repositorio.
2. Implementar la tarea en tu fork.
3. Crear un Pull Request contra el repositorio original con tu solución.

Gracias.
