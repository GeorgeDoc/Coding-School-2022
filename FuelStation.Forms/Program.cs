using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.Extensions.DependencyInjection;

namespace FuelStation.Forms {
    internal static class Program {
        public static IServiceProvider ServiceProvider { get; private set; }
 
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);


            ServiceProvider = services.BuildServiceProvider(); //not using, make global, or make a function to call. March 23, 2.15' recoding
            //var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            var loginForm = ServiceProvider.GetRequiredService<LogInForm>();
            Application.Run(loginForm);
        }
        private static void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IEntityRepo<Employee>, EmployeeRepo>(); //should be scoped?
            services.AddSingleton<IEntityRepo<Customer>, CustomerRepo>();
            services.AddSingleton<IEntityRepo<Item>, ItemRepo>();
            services.AddSingleton<IEntityRepo<Transaction>, TransactionRepo>();
            services.AddSingleton<IEntityRepo<TransactionLine>, TransactionLineRepo>();

            services.AddSingleton<CustomersForm>();
            services.AddSingleton<ItemsForm>();
            services.AddSingleton<TransactionsForm>();
            services.AddSingleton<LogInForm>();
            
        }
    }
}