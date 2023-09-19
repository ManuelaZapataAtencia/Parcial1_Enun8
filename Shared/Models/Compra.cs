using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial1_Enun8v4.Data.Entidades
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
