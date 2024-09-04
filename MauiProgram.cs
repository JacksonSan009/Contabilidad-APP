using Microsoft.Extensions.Logging;
using Contabilidad_APP.Components.Models.Services;
using Contabilidad_APP.Components.Models.Interfaces;

namespace Contabilidad_APP
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
                    fonts.AddFont("Nunito-ExtraLight.ttf", "Nunito");
                });

            builder.Services.AddSingleton<Config>();

            // Register the storage services
            builder.Services.AddSingleton(typeof(IStorageService<>), typeof(FileStorageService<>));
            builder.Services.AddSingleton<PreferencesService>();


            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
