using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Data.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        public int IdHotel { get; set; }

        public int IdHabitacion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        [Required, DataType(DataType.Currency)]
        public double Precio { get; set; }

        [Required]
        public Int16 Ocupacion { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Nombre tomador Invalido maximo caracteres {0}")]
        public string NombreTomador { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [ForeignKey("ClientId")]
        public virtual Usuarios ClienteId { get; set; }

        public virtual ICollection<TipoHabitacion> Habitaciones { get; set; }

    }
}
