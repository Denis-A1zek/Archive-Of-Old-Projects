using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Serilog;
using Sigida.Timetable.App.Services;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Infrastructures.MongoDb;
using Sigida.Timetable.Presentation.Services;
using Sigida.Timetable.Presentation.View;
using Sigida.Timetable.Presentation.ViewModel;

namespace Sigida.Timetable.Presentation
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

            builder.UseMauiCommunityToolkit();

            builder.Services.AddSingleton<IMongoContext, MongoContext>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            builder.Services.AddSingleton<TimetableService>();
            builder.Services.AddSingleton<TimetableInfoService>();
            builder.Services.AddSingleton<CourseInformationService>();

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPageView>();

            builder.Services.AddTransient<SpecialtiesPageView>();
            builder.Services.AddTransient<SpecialtiesViewModel>();

            builder.Services.AddTransient<GroupsViewModel>();
            builder.Services.AddTransient<GroupsPageView>();



            return builder.Build();
        }
    }
}