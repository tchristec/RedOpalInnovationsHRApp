﻿using Microsoft.Extensions.Logging;
using Plugin.Maui.ScreenBrightness;
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

            builder.Services.AddTransient<UpdateEmployeeViewModel>();
            builder.Services.AddTransient<UpdateEmployeePage>();

            builder.Services.AddTransient<EmployeeListPage>();
            builder.Services.AddTransient<EmployeeListViewModel>();

            builder.Services.AddTransient<EmployeeDetails>();
            builder.Services.AddTransient<EmployeeDetailsViewModel>();

            builder.Services.AddSingleton<SettingsPage>();
            builder.Services.AddTransient<SettingsViewModel>();

            builder.Services.AddSingleton(ScreenBrightness.Default);


            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Employee.db");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DatabaseService>(s, dbPath));

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}