using Microsoft.Extensions.Logging;
using MeteoApp.Services;
using System.IO;

namespace MeteoApp;

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

		// Percorso del database locale
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "MeteoApp.db");

        // Registra il servizio del database come Singleton
        builder.Services.AddSingleton(new LocalDatabaseService(dbPath));


#if DEBUG
		builder.Logging.AddDebug();
#endif
        return builder.Build();
	}
}

