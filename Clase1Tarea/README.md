# Clase 1 - Tarea: Juego Adivinar el Número

## Descripción

El usuario debe adivinar un número secreto generado aleatoriamente entre 1 y 100. En cada intento, el juego responde con una pista basada en la distancia entre el número ingresado y el secreto:

| Pista       | Condición        |
|-------------|------------------|
| Congelado   | distancia >= 50  |
| Frio        | 20 <= distancia < 50 |
| Tibio       | 5 <= distancia < 20  |
| Caliente    | distancia < 5        |

Al adivinar el número, se muestra la cantidad de intentos utilizados.

## Estructura del proyecto

```
Clase1Tarea/
├── Clase1Tarea.consola/           → Proyecto ejecutable 
│   └── Program.cs                 → Entrada de la aplicación, maneja input/output
├── Clase1Tarea.Logica/            → Biblioteca de clases 
│   ├── Juego/
│   │   ├── IJuegoNumero.cs        → Interfaz del juego
│   │   └── JuegoNumero.cs         → Implementación de la lógica del juego
│   └── IO/
│       ├── IConsola.cs            → Interfaz de entrada/salida
│       └── ConsolaWrapper.cs      → Implementación concreta usando Console
└── Clase1Tarea.Test/              → Pruebas unitarias (xUnit)
    └── JuegoNumeroTest.cs         → Tests de pistas, ganar, intentos y validación de rango
```
