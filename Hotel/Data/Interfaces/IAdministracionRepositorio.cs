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

        ICollection<Usuarios> ObtenerUsuariosByCriteria(Func<Usuarios, bool> filtro);

        ICollection<Categorias> ObtenerCategorias(Func<Categorias, bool> filtro);

        ICollection<Administrador> ObtenerAdministradores(Func<Administrador, bool> filtro);

    }
}
