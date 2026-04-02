using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase1.Logica.Juego
{
    // Lógica del juego separada para poder testearla sin depender de la consola
    public class JuegoAhorcado : IJuegoAhorcado
    {
        private readonly string palabraSecreta;
        private readonly HashSet<char> letrasAdivinadas = new();

        public int IntentosRestantes { get; private set; }

        public IReadOnlyCollection<char> LetrasAdivinadas => letrasAdivinadas;

        // Devuelve la palabra con '_' en las letras no adivinadas
        public string PalabraEnmascarada => new string(palabraSecreta.Select(c => letrasAdivinadas.Contains(c) ? c : '_').ToArray());

        public bool IsGanado => !PalabraEnmascarada.Contains('_');
        public bool IsPerdido => IntentosRestantes <= 0 && !IsGanado;

        public JuegoAhorcado(string palabraSecreta, int intentosMaximos = 6)
        {
            if (string.IsNullOrWhiteSpace(palabraSecreta)) throw new ArgumentException("La palabra secreta no puede estar vacía.", nameof(palabraSecreta));
            this.palabraSecreta = palabraSecreta.ToLowerInvariant();
            IntentosRestantes = intentosMaximos;
        }

        // Intenta adivinar una letra. Devuelve true si la letra está en la palabra.
        public bool Adivinar(char letra)
        {
            letra = char.ToLowerInvariant(letra);
            if (letrasAdivinadas.Contains(letra))
            {
                // Si ya se intentó esa letra, no cambia el estado (no resta intento)
                return palabraSecreta.Contains(letra);
            }

            letrasAdivinadas.Add(letra);

            if (palabraSecreta.Contains(letra))
            {
                return true;
            }

            IntentosRestantes--;
            return false;
        }
    }
}
