using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PetLink.ViewModels;

namespace PetLink
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<ProfileViewModel>();
            builder.Services.AddSingleton<PetProfileViewModel>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<LikedPetsViewModel>();
            builder.Services.AddSingleton<FindMyPetViewModel>();
            builder.Services.AddSingleton<DashboardViewModel>();
            builder.Services.AddSingleton<ContactShelterViewModel>();
            //builder.Services.AddSingleton<AboutYouViewModel>();

            return builder.Build();
        }
    }
}
