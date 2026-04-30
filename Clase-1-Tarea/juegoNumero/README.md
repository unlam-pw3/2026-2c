Crear un nuevo juego en este repositorio cuyo objetivo sea adivinar un número entero secreto (por ejemplo entre 1 y 100). En vez de indicar mayor/menor, el juego debe responder con una de estas pistas: congelado, frio, tibio, caliente. Y mostrar en que número de intento lo adivinó.

Comportamiento esperado (ejemplo de reglas):

Rango secreto: 1..100.
Calcular diff = |secreto - intento|.
congelado si diff >= 50.
frio si 20 <= diff < 50.
tibio si 5 <= diff < 20.
caliente si diff < 5