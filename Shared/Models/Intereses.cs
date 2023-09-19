using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Enun8.Shared.Models
{
    public class Interes
    {
        [Display(Name = "Id Intereses")]
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Cliente")]
        public Guid id_Cliente { get; set; }

        [Display(Name = "Intereses")]
        [MaxLength(70, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string DescripcionInteres { get; set; }

        public List<Cliente> Cliente { get; set; }
    }
}
