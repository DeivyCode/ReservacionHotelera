using Hotel.Data;
using Hotel.Data.Interfaces;
using Hotel.Data.Repositorio;
using Hotel.UI;
using Hotel.UI.Administracion;
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

            ConfigurarServicios();
            ApplicationConfiguration.Initialize();

            // Verficar Autentificacion del usuario
            var loginForm = ServiceProvider.GetRequiredService<Login>();

            if (loginForm.ShowDialog() == DialogResult.OK)
                Application.Run(ServiceProvider.GetRequiredService<ViewUsuarios>());
            else
                Application.Exit();


            using (var hotelContext = new HotelDbContext())
            {
                Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions
                         .MigrateAsync(hotelContext.Database).Wait();
            }
        }

        static void ConfigurarServicios()
        {
            var servicios = new ServiceCollection();
            servicios.AddSingleton<HotelDbContext>();
            servicios.AddScoped<IAdministracionRepositorio, AdministracionRepositorioImp>();
            servicios.AddScoped<IHotelRepository, HotelRepositoryImp>();
            servicios.AddTransient<Login>();
            servicios.AddTransient<ViewUsuarios>();
            servicios.AddTransient<MenuPrincipal>();
            ServiceProvider = servicios.BuildServiceProvider();

        }
    }
}