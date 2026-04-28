using CommunityToolkit.Mvvm.ComponentModel;
using PetLink.Models.Titles;

namespace PetLink.View_Models
{
    public partial class PetProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        private ImageSource imageSourceURL;
        public string Name => TitlePetProfile.Name;
        public string Species => TitlePetProfile.Species;
        public string Age => TitlePetProfile.Age;
        public string Weight => TitlePetProfile.Weight;

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