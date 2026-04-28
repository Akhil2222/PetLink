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
        private string submit = TitleRegister.Submit;


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
            //If any required field is empty
            if (string.IsNullOrWhiteSpace(firstname)
                || string.IsNullOrWhiteSpace(lastname)
                || string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(confirmPassword))
            {
                await Shell.Current.DisplayAlert(TitleRegister.Title, "Please fill in all required fields.", "OK");
                return;
            }

            //Password must meet all specifications
            if (password.Length < 8)
            {
                await Shell.Current.DisplayAlert(TitleRegister.Title, passwordConditions, "OK");
                return;
            }

            //confirmPassword must match password
            if (!password.Equals(confirmPassword))
            {
                await Shell.Current.DisplayAlert(TitleRegister.Title, "Passwords do not match.", "OK");
                return;
            }

            //Every entry is filled correctly
            await Shell.Current.GoToAsync($"{nameof(AboutYouPage)}");
        }

        public RegisterViewModel()
        {
        }
    }
}