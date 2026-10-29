using System;
using System.Collections.Generic;
using System.Text;
using Clase6.EF.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Clase6.EF.Tests
{
    public class Contexto
    {
        public static JugueteriaDbContext CrearContexto()
        {
            var options = new DbContextOptionsBuilder<JugueteriaDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new JugueteriaDbContext(options);
        }

        public static void LlenarBaseDeDatosConRegistros(JugueteriaDbContext context, int cantidad)
        {
            context.Tematicas.Add(new Tematica { Id = 1, Nombre = "Tecnología" });
            context.Tematicas.Add(new Tematica { Id = 2, Nombre = "Construcción" });

            for (var i = 1; i <= cantidad; i++)
            {
                context.Juguetes.Add(new Juguete
                {
                    Nombre = $"Juguete {i}",
                    Precio = 1000 + i,
                    EdadRecomendada = 6,
                    TematicaId = 1
                });
            }

            context.SaveChanges();
        }
    }


}
