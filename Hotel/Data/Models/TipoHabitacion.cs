using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class TipoHabitacion
    {
        [Key]
        public int IdHotel { get; set; }

        [Required]
        public virtual ICollection<Habitacion> IdHabitacion { get; set; }

        [Required, MaxLength(1000, ErrorMessage = "Descripcion invalida maximo caracteres permitidos {0}")]
        public string Descripcion { get; set; }

        [Required, DataType(DataType.Currency)]
        public double Precio { get; set; }

        [Required]
        public Int16 NumHabitaciones { get; set; }

    }
}
