using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Enun8.Shared.Models
{
    public class Empleado
    {
        [Display(Name = "Id Empleado")]
        [Key]
        public Guid Id_Empleado { get; set; }

        [Display(Name = "Nombre Empleado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NombreCompletoE { get; set; }

    }
}
