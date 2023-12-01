using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MRecipes.Services;
using MRecipes.Storage;
using MRecipes.ViewModels;

namespace MRecipes;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddDbContext<DataContext>();

        var dbContext = new DataContext();
        dbContext.Database.EnsureCreated();
        dbContext.Dispose();

        builder.Services.AddScoped<MainPageViewModel>();
        builder.Services.AddScoped<CategoryContentViewModel>();
        builder.Services.AddScoped<RecipeContentViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif
        var app = builder.Build();

        ServiceHelper.Initialize(app.Services);

        return app;
    }
}
