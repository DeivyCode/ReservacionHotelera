
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


            using var hotelContext = new HotelDbContext();
            Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions
                .Migrate(hotelContext.Database);

            // Verficar Autentificacion del usuario
            var loginForm = ServiceProvider.GetRequiredService<Login>();

            if (loginForm.ShowDialog() == DialogResult.OK)
                Application.Run(ServiceProvider.GetRequiredService<MainMenu>());
            else
                Application.Exit();
        }

        static void ConfigurarServicios()
        {
            var servicios = new ServiceCollection();
            servicios.AddSingleton<HotelDbContext>();
            servicios.AddScoped<IAdministracionRepositorio, AdministracionRepositorioImp>();
            servicios.AddScoped<IHotelRepository, HotelRepositoryImp>();
            servicios.AddTransient<Login>();
            servicios.AddTransient<MainMenu>();
            servicios.AddTransient<MenuPrincipal>();
            servicios.AddTransient<CrearUsuarios>();
            servicios.AddTransient<ListadoUsuarios>();
            servicios.AddTransient<ListadoHoteles>();
            servicios.AddTransient<CrearHoteles>();
            servicios.AddTransient<CrearHabitaciones>();
            servicios.AddTransient<CrearTipoHabitacion>();
            servicios.AddTransient<CrearReservaciones>();
            servicios.AddTransient<ListadoReservaciones>();
            servicios.AddTransient<ListadoTipoHabitaciones>();
            servicios.AddTransient<ListadoHabitaciones>();
            ServiceProvider = servicios.BuildServiceProvider();

        }
    }
}