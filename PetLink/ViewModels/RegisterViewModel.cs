using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using PetLink.Pages;

namespace PetLink.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleRegister.Title;

        [ObservableProperty]
        private string passwordConditions = TitleRegister.PasswordConditions;

        
        [ObservableProperty]
        private string firstname;
        
        [ObservableProperty]
        private string lastname;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string confirmPassword;

        [RelayCommand]
        private async Task RegisterSubmitClicked()
        {
            if (string.IsNullOrWhiteSpace(firstname)
                && string.IsNullOrWhiteSpace(lastname)
                && string.IsNullOrWhiteSpace(username)
                && string.IsNullOrWhiteSpace(password)
                && string.IsNullOrWhiteSpace(confirmPassword))
            {
                await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
                return;
            }

            else
            {
                //await Shell.Current.GoToAsync($"{nameof(AboutYouPage)}");
            }
        }

        public RegisterViewModel()
        {
        }
    }
}