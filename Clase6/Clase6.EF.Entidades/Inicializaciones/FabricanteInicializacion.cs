using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF.Entidades.Inicializaciones;

public class FabricanteInicializacion
{
    public static void Inicializar(JugueteriaDbContext db)
    {
        if(db.Fabricantes.Any())
            return;

        db.Fabricantes.AddRange(
            new Fabricante { Nombre = "Hasbro", Pais = "Estados Unidos" },
            new Fabricante { Nombre = "Mattel", Pais = "Estados Unidos" },
            new Fabricante { Nombre = "LEGO", Pais = "Dinamarca" }
        );
        db.SaveChanges();
    }
}
