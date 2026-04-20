using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using PetLink.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        public string Title => TitleLogin.Title;
        public string UsernameText => TitleLogin.UsernameText;
        public string PasswordText => TitleLogin.PasswordText;
        public string Submit => TitleLogin.Submit;

        [RelayCommand]
        private async Task SubmitClicked()
        {
            await Shell.Current.GoToAsync(nameof(DashboardPage));
        }
    }

}
