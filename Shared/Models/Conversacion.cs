using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial1_Enun8v4.Data.Entidades
{
    public class Conversacion 
    {
        [Key]
        public Guid Id_Conversacion { get; set; }

        [Display(Name = "ID Cliente")]
        [ForeignKey ("Cliente")]
        public Guid Id_Cliente { get; set; }

        [Display(Name = "ID Empleado")]
        [ForeignKey("Empleado")]
        public Guid Id_Empleado { get; set; }

        [Required]
        public string Mensaje { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaEnvio { get; set; }

      

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }
    }
}
