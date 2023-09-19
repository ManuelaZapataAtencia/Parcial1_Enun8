using Parcial1_Enun8v4.Data.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Enun8.Shared.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "ID del Cliente")]
        public Guid Id_Cliente { get; set; }

        [Display(Name = "Nombre completo Cliente")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string NombreCompleto { get; set; }

        [Display(Name = "Número de teléfono")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //Campo requerido
        public string NumeroTelefono { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Direccion { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }



        public List<Interes> Intereses { get; set; }

        public List<Compra> HistorialCompras { get; set; }

        public List<Conversacion> Conversaciones { get; set; }
    }
}
