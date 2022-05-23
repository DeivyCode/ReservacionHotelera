
using Hotel.Data;
using Hotel.Data.Interfaces;
using Hotel.Data.Repositorio;
using Hotel.UI;
using Hotel.UI.Administracion;
using Hotel.UI.Hotel;
using Microsoft.Extensions.DependencyInjection;
namespace Hotel
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            ConfigurarServicios();

            // Verficar Autentificacion del usuario
            var loginForm = ServiceProvider.GetRequiredService<CrearTipoHabitacion>();

            if (loginForm.ShowDialog() == DialogResult.OK)
                Application.Run(ServiceProvider.GetRequiredService<ListadoHoteles>());
            else
                Application.Exit();


            using var hotelContext = new HotelDbContext();
            Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions
                .Migrate(hotelContext.Database);
        }

        static void ConfigurarServicios()
        {
            var servicios = new ServiceCollection();
            servicios.AddSingleton<HotelDbContext>();
            servicios.AddScoped<IAdministracionRepositorio, AdministracionRepositorioImp>();
            servicios.AddScoped<IHotelRepository, HotelRepositoryImp>();
            servicios.AddTransient<Login>();
            servicios.AddTransient<MenuPrincipal>();
            servicios.AddTransient<CrearUsuarios>();
            servicios.AddTransient<MenuPrincipal>();
            servicios.AddTransient<ListadoUsuarios>();
            servicios.AddTransient<ListadoHoteles>();
            servicios.AddTransient<CrearHoteles>();
            servicios.AddTransient<CrearHabitaciones>();
            servicios.AddTransient<CrearTipoHabitacion>();
            ServiceProvider = servicios.BuildServiceProvider();

        }
    }
}