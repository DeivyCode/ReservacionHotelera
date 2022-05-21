using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Interfaces
{
    public interface IAdministracionRepositorio
    {
        bool CrearUsuario(Usuarios user);

        ICollection<Usuarios> GetUsuarios();

        bool EditarUsuario(Usuarios model);

        bool BorrarUsuario(int id);

        bool AutentificarUsuario(Usuarios user);

        ICollection<Usuarios> GetUsuariosByCriteria(Func<Usuarios,bool> filtro);

    }
}
