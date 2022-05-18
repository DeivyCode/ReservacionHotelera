using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositorio
{
    public class UsuarioRepositorioImp : IUsuarioRepositorio
    {
        private readonly HotelDbContext context;

        public UsuarioRepositorioImp(HotelDbContext context)
        {
            this.context = context;
        }

        public bool AutentificarUsuario(string password, string email)
        {
            return true;
        }

        public bool BorrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuarios user)
        {
            throw new NotImplementedException();
        }

        public bool EditarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Usuarios> GetUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
