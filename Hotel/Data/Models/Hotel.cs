using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required, MaxLength(100)]
        public string Domicilio { get; set; }

        [Required, MaxLength(100)]
        public string Localidad { get; set; }

        [Required, MaxLength(100)]
        public string Provincia { get; set; }

        public int IdCategoria { get; set; }

        public int IdAdministrador { get; set; }

        [ForeignKey("IdAdministrador")]
        public virtual Administrador Administrador{ get; set; }


        [ForeignKey("IdCategoria")]
        public Categorias Categoria { get; set; }
    }
}
