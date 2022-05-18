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

        public bool AutentificarUsuario(Usuarios usuario)
        {
            var user = context.Usuarios.
                Where(x => x.Clave == usuario.Clave.Trim().ToLower() && x.Usuario == usuario.Usuario.Trim().ToLower())
                .FirstOrDefault();
            if (user == null) return false;
            return true;
        }

        public bool BorrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuarios user)
        {
            if (user == null) return false;

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Usuarios.Add(user);
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }

            }
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
