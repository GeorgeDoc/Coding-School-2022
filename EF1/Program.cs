using Microsoft.Extensions.DependencyInjection;
using Classes;
using Session_15_EF.Repositories;

namespace EF1 {
    internal static class Program {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<Transaction>, TransactionRepo>();
            services.AddSingleton<Menu>();

            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<Menu>();
            Application.Run(mainForm);
        }
    }
}