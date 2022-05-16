using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        [MaxLength(50,ErrorMessage = "Usuario invalido maximo caracteres {0}")]
        public string Usuario { get; set; }

        [MaxLength(50,ErrorMessage = "Nombre invalido maximo caracteres {0}")]
        public string Nombres { get; set; }

        [MaxLength(50,ErrorMessage = "Apellido invalido maximo caracteres {0}")]
        public string Apellidos { get; set; }

        [MaxLength(255), EmailAddress(ErrorMessage = "Correo no valido")]
        public string Correo { get; set; }

        [MaxLength(60)]
        public string Clave { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsAdmin { get; set; } = false;
    }
}
