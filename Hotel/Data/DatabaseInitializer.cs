using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class DatabaseInitializer
    {
        private readonly ModelBuilder modelBuilder;
        public DatabaseInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void SeedDatabase()
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                IdUsuario = 1,
                Apellidos = "N/A",
                Nombres = "Administrador",
                Clave = "admin",
                Usuario = "admin",
                Correo = "admin@mail.com",
                IsActive = true,
                IsAdmin = true,
            });
            modelBuilder.Entity<Categorias>().HasData(
                new Categorias
                {
                    Id = 1,
                    CategoriaNombre = "1 ESTRELLA",
                    IsActive = true
                },
                new Categorias
                {
                    Id = 2,
                    CategoriaNombre = "2 ESTRELLAS",
                    IsActive = true
                },
                new Categorias
                {
                    Id = 3,
                    CategoriaNombre = "3 ESTRELLAS",
                    IsActive = true
                },
                new Categorias
                {
                    Id = 4,
                    CategoriaNombre = "4 ESTRELLAS",
                    IsActive = true
                },
                new Categorias
                {
                    Id = 5,
                    CategoriaNombre = "5 ESTRELLAS",
                    IsActive = true
                }
                );
        }
    }
}
