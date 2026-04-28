using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using PetLink.Pages;

namespace PetLink.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public string Title => TitleMain.Title;
        public string Login => TitleMain.Login;
        public string Register => TitleMain.Register;

        [RelayCommand]
        private async Task LoginClicked()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        [RelayCommand]
        private async Task RegisterClicked()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

        [RelayCommand]
        private async Task AboutYouClicked()
        {
            //await Shell.Current.GoToAsync(nameof(AboutYouPage));
        }

        [RelayCommand]
        private async Task PetProfileClicked()
        {
            await Shell.Current.GoToAsync(nameof(PetProfilePage));
        }

        public MainViewModel()
        {

        }
    }
}
