using Microsoft.Extensions.Logging;
using NewsApp.Services;
using NewsApp.View;
using NewsApp.ViewModel;

namespace NewsApp
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
            builder.Services.AddSingleton<MockNewsService>();
            builder.Services.AddSingleton<NewsViewModel>();
            builder.Services.AddSingleton<NewsPage>();
            builder.Services.AddSingleton<NewsDetailPage>();
            builder.Services.AddSingleton<NewsDetailPageModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}