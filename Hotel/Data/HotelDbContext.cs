using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext()
        {

        }
        public HotelDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<TipoHabitacion> TipoHabitacion { get; set; }
        public DbSet<Reserva> Reservaciones { get; set; }
        public DbSet<Models.Hotel> Hotel { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Properties.Settings.Default.ConnectionSource)
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<decimal>()
                .HavePrecision(18, 6);


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Llave primaria Compuesta
            modelBuilder.Entity<TipoHabitacion>()
                .HasKey(e => new { e.IdHotel, e.IdHabitacion });
            new DatabaseInitializer(modelBuilder).SeedDatabase();
        }
    }
}

