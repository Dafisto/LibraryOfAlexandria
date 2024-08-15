using LibraryOfAlexandria.ClassPackage.Persistence;
using SQLite;
using Microsoft.Extensions.Logging;
using LibraryOfAlexandria.ClassPackage.Domain;


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
                  
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "alexandriaDataBase.db");
            builder.Services.AddSingleton<DataBase>(s => ActivatorUtilities.CreateInstance<DataBase>(s, dbPath));

            builder.Services.AddSingleton<BooksManager>();



            return builder.Build();
        }
    }
}
