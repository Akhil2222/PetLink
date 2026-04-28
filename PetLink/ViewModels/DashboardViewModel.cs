using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using PetLink.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        //public string Layouts { get; set; } = TitleMain.Layouts;
        //public string Images { get; set; } = TitleMain.Images;
        //public string Collections { get; set; } = TitleMain.Collections;
        //public string Controls { get; set; } = TitleMain.Controls;
        //public string SQLLITE { get; set; } = TitleMain.SQLLite;

        [ObservableProperty]
        private string title = TitleDashboard.Title;

        [ObservableProperty]
        private string profile = TitleDashboard.Profile;

        [ObservableProperty]
        private string findMyPet = TitleDashboard.FindMyPet;

        [ObservableProperty]
        private string likedPets = TitleDashboard.LikedPets;

        [RelayCommand]
        private async Task ProfileClicked()
        {
            await Shell.Current.GoToAsync(nameof(ProfilePage));
        }

        [RelayCommand]
        private async Task FindMyPetClicked()
        {
            await Shell.Current.GoToAsync(nameof(FindMyPetPage));
        }

        [RelayCommand]
        private async Task LikedPetsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LikedPetsPage));
        }

        [RelayCommand]
        private async Task AboutYouClicked()
        {
            await Shell.Current.GoToAsync(nameof(AboutYouPage));
        }

        public DashboardViewModel()
        {

        }
    }
}
