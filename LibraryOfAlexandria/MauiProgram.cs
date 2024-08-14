using LibraryOfAlexandria.ClassPackage.Persistence;
using SQLite;
using Microsoft.Extensions.Logging;

namespace LibraryOfAlexandria
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<DataBase>();       
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "alexandriaDataBase.db");
            builder.Services.AddSingleton<DataBase>(s => ActivatorUtilities.CreateInstance<DataBase>(s, dbPath));



            return builder.Build();
        }
    }
}
