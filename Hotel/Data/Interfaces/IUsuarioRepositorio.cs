using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Interfaces
{
    public interface IUsuarioRepositorio
    {
        bool CrearUsuario(Usuarios user);

        ICollection<Usuarios> GetUsuarios();

        bool EditarUsuario(int id);

        bool BorrarUsuario(int id);

        bool AutentificarUsuario(string password, string email);
    }
}
