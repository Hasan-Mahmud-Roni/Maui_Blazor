using MauiBlazorEvidence.Client.Data;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace MauiBlazorEvidence.Client
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
            

            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddMauiBlazorWebView();
            

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}