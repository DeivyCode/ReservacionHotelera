using Hotel.Data;
using Hotel.Data.Interfaces;
using Hotel.Data.Repositorio;
using Hotel.UI;
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
            Application.Run(ServiceProvider.GetRequiredService<Login>());
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
            servicios.AddTransient<Login>();
            ServiceProvider = servicios.BuildServiceProvider();
        }
    }
}