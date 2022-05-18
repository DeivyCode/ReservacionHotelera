using Hotel.Data.Interfaces;
using Hotel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositorio
{
    public class AdministracionRepositorioImp : IAdministracionRepositorio
    {
        private readonly HotelDbContext context;

        public AdministracionRepositorioImp(HotelDbContext context)
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
            if (id == 0) return false;

            using var transaction = context.Database.BeginTransaction();
            var userExits = context.Usuarios.Where(x => x.IdUsuario == id).FirstOrDefault();

            if (userExits == null) return false;

            try
            {
                context.Usuarios.Attach(userExits);
                context.Usuarios.Remove(userExits);
                context.SaveChanges();

                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public bool CrearUsuario(Usuarios user)
        {
            if (user == null) return false;

            using var transaction = context.Database.BeginTransaction();
            try
            {
                if (user.IsAdmin)
                    context.Administradores.Add(new Administrador
                    {
                        Nombre = user.Nombres,
                    });

                context.Usuarios.Add(user);
                context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public bool EditarUsuario(int id)
        {
            return false;
        }

        public ICollection<Usuarios> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }
    }
}
