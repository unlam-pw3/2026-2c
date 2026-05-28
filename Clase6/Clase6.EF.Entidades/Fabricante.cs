using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF.Entidades;

public class Fabricante
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(200)]
    public string Pais { get; set; }

    public List<Juguete> Juguetes { get; set; }
}
