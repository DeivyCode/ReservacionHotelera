using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Hotel
    {
        [Key]
        public int IdHotel { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public Int16 Categoria { get; set; }

        [Required, MaxLength(100)]
        public string Domicilio { get; set; }

        [Required, MaxLength(100)]
        public string Localidad { get; set; }

        [Required, MaxLength(100)]
        public string Provincia { get; set; }

        [Required]
        public virtual Administrador AdministradorId { get; set; }
    }
}
