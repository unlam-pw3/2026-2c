using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase6.EF.Entidades.Inicializaciones;

namespace Clase6.EF.Entidades;

public class JuguetesDbInicializaciones
{
    public static void Inicializar(JugueteriaDbContext db)
    {
        FabricanteInicializacion.Inicializar(db);
    }
}
