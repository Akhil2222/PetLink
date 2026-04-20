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

        public MainViewModel()
        {

        }
    }
}
