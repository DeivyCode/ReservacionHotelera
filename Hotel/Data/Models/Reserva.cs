using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Data.Models
{
    public class Reserva
    {
        [Key]
        [Column(Order = 0)]
        public int IdReserva { get; set; }
        [Column(Order = 1)]
        public int IdHotel { get; set; }
        [Column(Order = 2)]
        public int IdHabitacion { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime FechaFin { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required]
        public Int16 Ocupacion { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Nombre tomador Invalido maximo caracteres {0}")]
        public string NombreTomador { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Usuarios Usuarios { get; set; }

        [ForeignKey("IdHotel,IdHabitacion")]
        public virtual TipoHabitacion Habitaciones { get; set; }

    }
}
