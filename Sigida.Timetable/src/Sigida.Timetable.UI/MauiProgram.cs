using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Serilog;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Infrastructures.MongoDb;
using Sigida.Timetable.UI.Service;
using Sigida.Timetable.UI.Services;
using Sigida.Timetable.UI.View;
using Sigida.Timetable.UI.ViewModel;

namespace Sigida.Timetable.UI
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
                    fonts.AddFont("Nunito.ttf", "Nunito");
                });

            var file = Path.Combine(FileSystem.AppDataDirectory, "log.log");

            Log.Logger = new LoggerConfiguration()
           .WriteTo.File(file, rollingInterval: RollingInterval.Month)
           .CreateLogger();

            builder.UseMauiCommunityToolkit();

            builder.Services.AddSingleton<IMongoContext, MongoContext>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            builder.Services.AddSingleton<FacultyInfoService>();
            builder.Services.AddTransient<TimetableInfoService>();

            builder.Services.AddSingleton<FacultiesViewModel>();
            builder.Services.AddSingleton<FaluctiesPageView>();

            builder.Services.AddTransient<SpecialtiesPageView>();
            builder.Services.AddTransient<SpecialtiesViewModel>();

            builder.Services.AddTransient<GroupViewModel>();
            builder.Services.AddTransient<GroupPageView>();

            return builder.Build();
        }
    }
}