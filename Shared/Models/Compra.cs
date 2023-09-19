using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Enun8.Shared.Models
{
    public class Compra
    {
        [Display(Name = "ID de la compra")]
        [Key]
        public Guid Id_Compra { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCompra { get; set; }

        [Display(Name = "ID del Cliente")]
        [ForeignKey("Cliente")]
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Vehiculo")]
        [Display(Name = "ID del vehiculo")]
        public Guid VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
