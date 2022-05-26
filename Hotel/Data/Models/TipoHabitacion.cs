using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class TipoHabitacion
    {
        [Required]
        public int IdHotel { get; set; }
        [Required]
        public int IdHabitacion { get; set; }

        [Required, MaxLength(1000, ErrorMessage = "Descripcion invalida maximo caracteres permitidos {0}")]
        public string Descripcion { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Required]
        public Int16 NumHabitaciones { get; set; }

        [NotMapped]
        public virtual Habitacion Habitacion { get; set; }
        [NotMapped]
        public virtual Hotel Hotel { get; set; }

        public Reserva Reserva { get; set; }
    }
}
