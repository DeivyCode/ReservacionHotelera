using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Models
{
    public class Categorias
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string  CategoriaNombre{ get; set; }
        public bool IsActive { get; set; } = true;
    }
}
