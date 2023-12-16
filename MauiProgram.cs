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

            builder.Services.AddSingleton<EmployeeListPage>();
            builder.Services.AddSingleton<EmployeeListViewModel>();

            builder.Services.AddTransient<EmployeeDetails>();
            builder.Services.AddTransient<EmployeeDetailsViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}