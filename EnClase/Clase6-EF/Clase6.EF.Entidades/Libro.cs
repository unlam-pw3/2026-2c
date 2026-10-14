using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor {  get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public List<Categoria> Categorias { get; set; } = new();
    }
}
