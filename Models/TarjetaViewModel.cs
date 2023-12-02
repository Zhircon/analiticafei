using System.ComponentModel.DataAnnotations;

namespace AnaliticaFEI.Models
{
    public class TarjetaViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name="Tarjeta de crédito")]
        public string Card_number { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [Display(Name ="Nombre como aparece en la tarjeta")]
        public string Name { get; set; }
        [Required(ErrorMessage="El campo {0} es obligatorio.")]
        [Display(Name="Expiracion")]
        public string Expiry { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(3,ErrorMessage = "El campo {0} debe ser una cadena con un maxim de {1} caracteres.")]
        [Display(Name ="CVV")]
        public string Cvv { get; set; }
    }
}