using CommunityToolkit.Mvvm.ComponentModel;
using PetLink.Models.Titles;

namespace MyFirstMauiApp.View_Models
{
    public partial class PetProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private ImageSource imageSourceURL;
        public PetProfileViewModel()
        {
            ImageSourceURL = new UriImageSource
            {
                Uri = new Uri(TitlePetProfile.Image),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)

            };
        }

    }
}