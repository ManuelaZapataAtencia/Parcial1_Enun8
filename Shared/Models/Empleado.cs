using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Parcial1_Enun8v4.Data.Entidades
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
