using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Habitacion
    {
        [Key]
        public int IdHabitacion { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage = "Nombre no valido maximo caracteres {0}")]
        public string Nombre { get; set; }

        [Required]
        public Int16 Capacidad { get; set; }

        public TipoHabitacion TipoHabitacion { get; set; }
    }
}
