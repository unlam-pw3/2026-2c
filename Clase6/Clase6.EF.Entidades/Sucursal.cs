using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF.Entidades
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Altura { get; set; }
        public List<Juguete> Juguetes { get; set; } = new();
    }
}
