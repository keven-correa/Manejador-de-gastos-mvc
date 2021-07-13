using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manejo_Ingreso_Gasto.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(120)]
        [Display(Name = "Nombre categoria")]
        public string NombreCategoria { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } //GA -> Gasto y IN -> Ingreso

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool Estado { get; set; }

    }
}
