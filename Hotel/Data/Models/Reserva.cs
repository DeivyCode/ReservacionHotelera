using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

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

        public virtual Usuarios ClienteId { get; set; }

        public  int IdHotel { get; set; }

        public  int IdHabitacion { get; set; }

        // Propieda de Navegacion
        public virtual ICollection<TipoHabitacion> TipoHabitacion { get; set; }

    }
}
