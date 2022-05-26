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
            var user = context.Usuarios
                .FirstOrDefault(x => x.Clave == usuario.Clave.Trim().ToLower() && x.Usuario == usuario.Usuario.Trim().ToLower());
            return user != null;
        }

        public bool BorrarUsuario(int id)
        {
            if (id == 0) return false;

            using var transaction = context.Database.BeginTransaction();
            var userExits = context.Usuarios.FirstOrDefault(x => x.IdUsuario == id);

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
                        NombreAdministrador = user.Nombres,
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

        public bool EditarUsuario(Usuarios model)
        {
            var entry = context.ChangeTracker.Entries<Usuarios>()
                                                    .FirstOrDefault(x => x.Entity.IdUsuario == model.IdUsuario);

            if (entry == null)
            {
                context.Update(model);
            }
            else
            {
                entry.CurrentValues.SetValues(model);
            }

            if (context.SaveChanges() > 0) return true;

            return false;
        }

        public ICollection<Usuarios> GetUsuarios()
        {

            return context.Usuarios.ToList();
        }

        public ICollection<Usuarios> ObtenerUsuariosByCriteria(Func<Usuarios, bool> filtro)
        {
            return context.Usuarios.Where(filtro).ToList();
        }

        public ICollection<Categorias> ObtenerCategorias(Func<Categorias, bool> filtro)
        {
            return context.Categorias.Where(filtro).ToList();
        }

        public ICollection<Administrador> ObtenerAdministradores(Func<Administrador, bool> filtro)
        {
            return context.Administradores.Where(filtro).ToList();
        }
    }
}
