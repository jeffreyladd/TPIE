using Microsoft.Extensions.Configuration;
using System.Reflection;
using TPIE.UI;

namespace TPIE.App
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

            var ass = Assembly.GetExecutingAssembly();
            using var appSettingsStream = ass.GetManifestResourceStream("appsettings.json");

            var config = new ConfigurationBuilder()
                        .AddJsonStream(appSettingsStream)
                        .Build();


            builder.Configuration.AddConfiguration(config);

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            //builder.Logging.AddDebug();
#endif

            builder.Services.SetupTPIEUI(builder.Configuration);

            return builder.Build();
        }
    }
}