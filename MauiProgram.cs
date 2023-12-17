using Microsoft.Extensions.Logging;
using RedOpalInnovationsHRApp.ViewModel;

namespace RedOpalInnovationsHRApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();

            builder.Services.AddTransient<AddEmployeePage>();
            builder.Services.AddTransient<AddEmployeeViewModel>();

            builder.Services.AddTransient<EmployeeListPage>();
            builder.Services.AddTransient<EmployeeListViewModel>();

            builder.Services.AddTransient<EmployeeDetails>();
            builder.Services.AddTransient<EmployeeDetailsViewModel>();


            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Employee.db");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DatabaseService>(s, dbPath));

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}