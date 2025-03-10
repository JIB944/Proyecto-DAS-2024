using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using TiendaMinorista.Datos;

namespace Proyecto_DAS_2024
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        [STAThread]
        static void Main()
        {
            // Cargar el archivo de configuración (appsettings.json)
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Directorio base
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build(); // Configuración cargada desde el archivo JSON

            // Obtener la cadena de conexión desde la configuración
            var connectionString = Configuration.GetConnectionString("DefaultConnection"); // Cambiar aquí a tu clave en appsettings.json

            // Configurar el DbContext
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Crear una instancia de ApplicationDbContext
            var dbContext = new ApplicationDbContext(optionsBuilder.Options);

            // Inicia la aplicación
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(dbContext)); // Pasa dbContext al Form1
        }
    }
}



