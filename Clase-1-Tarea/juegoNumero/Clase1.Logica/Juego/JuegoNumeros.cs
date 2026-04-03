using Clase1.Logica.Juego;

public class JuegoNumeros : IJuegoNumeros
{

    // instancio un objeto de la clase Random (no es un numero)
    private Random random = new Random();

    // el metodo set lo hago privado para que no se lo pueda modificar desde afuera    
    public int Intentos {get; private set; }

    public int Min {get; private set; }
    public int Max {get; private set;}

    public bool Finalizado {get; set;}
    
    // constructor
    public JuegoNumeros(int min, int max)
    {
        Min = min;
        Max = max;
    }

    // internal para poder usarlo en los test y no exponerlo publicamente (ver Properties/AssemblyInfo.cs)
    public int NumeroRandom {get; internal set;}

    // constructor para generar los valores limites
    private int[] limites = new int[3];

    // genero el random despues de instanciar la clase, para que no repita el mismo seed
    // el maximo es excluyente, por eso le sumo 1 al valor pasado
    public int Generar() {
        NumeroRandom = random.Next(Min, Max + 1);
        // calculo los limites dentro del metodo (fuera no puedo porque Max no puede ser un valor estatico)
        limites[0] = (int)Math.Round((Max - Min) * 0.05);
        limites[1] = (int)Math.Round((Max - Min) * 0.20);
        limites[2] = (int)Math.Round((Max - Min) * 0.50);
        return NumeroRandom;
    }
    
    public string Pista(int numElegido)
    {

        int modulo = Math.Abs(NumeroRandom - numElegido);
        string respuesta;

         if (numElegido > Max || numElegido < Min) {
            respuesta = "No existe el " + numElegido + ", señor";
         } else if (modulo == 0) {
            // suma 1 a  los intentos pero no lo guarda (se guarda al final)
            respuesta = "Lo conseguiste en " + (Intentos + 1)+ " intentos";
            Finalizado = true;
         }
         else if (modulo < limites[0]) {
            respuesta = "CALIENTE!";
         } else
         if (modulo < limites[1]) {
            respuesta = "Tibio Tibio";
         } else
         if (modulo < limites[2]) {
            respuesta = "Friiiiio";
         } else
        {
            respuesta = "En el freezer";
        }
        Intentos++;
        return respuesta;
    }
}