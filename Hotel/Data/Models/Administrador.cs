using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Administrador
    {
        [Key]
        public int IdAdministrador { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Nombre no valido maximo caracteres {0}")]
        public string NombreAdministrador { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

    }
}
