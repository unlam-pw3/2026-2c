using Clase1.Logica.Juego;

public class JuegoNumeros : IJuegoNumeros
{

    private Random numero = new Random();
    
    public int Intentos {get; private set; }

    public int Min {get; set;}
    public int Max {get; set;}
    public int Generar() => numero.Next(Min, Max);

    public string Pista(int numRandom, int numElegido)
    {
                  
        int modulo = Math.Abs(numRandom - numElegido);
        string respuesta;

         if (numElegido > Max || numElegido < Min) {
            respuesta = "No existe el " + numElegido + ", señor";
            Intentos++;
            return respuesta;
         } 
        
        switch(modulo)
        {
            case 0: respuesta = "Lo conseguiste en " + ++Intentos + " intentos";
                break;
            case <5: respuesta = "CALIENTE!";
                     Intentos++;
                break;
            case <20: respuesta = "Tibio Tibio";
                     Intentos++;
                break;
            case <50: respuesta = "Friiiiio";
                     Intentos++;
                break;
            default: respuesta = "En el freezer";
                     Intentos++;
                break;
        }
        return respuesta;
    }
}