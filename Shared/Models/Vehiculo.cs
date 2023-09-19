using System.ComponentModel.DataAnnotations;

namespace Parcial1_Enun8v4.Data.Entidades
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
