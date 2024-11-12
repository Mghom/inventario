using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioControlador.Entidades
{
    public  class Tipo
    {
        public int Id { get; set; }

        [Display(Name = "Tipo")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "el campo {0} es obligatorio")]
        public string Name { get; set; } = null!;
        public string ? Categoria { get; set; }
    }
}
