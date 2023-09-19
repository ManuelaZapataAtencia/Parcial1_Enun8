using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Enun8.Shared.Models
{
    public class Vehiculo
    {
        [Key]
        [Display(Name = "Id Vehiculo")]
        public Guid Id_Vehiculo { get; set; }

        [Required]
        [Display(Name = "Marca Vehiculo")]
        public string Marca { get; set; }

        [Required]
        [Display(Name = "Modelo Vehiculo")]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Precio vehiculo")]
        public decimal Precio { get; set; }

        [Display(Name = "Caracteristicas del vehiculo")]
        public string Caracteristica { get; set; }

        public string Imagen { get; set; }
    }
}
