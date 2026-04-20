
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using PetLink.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleRegister.Title;
        
        [ObservableProperty]
        private string passwordConditions = TitleRegister.PasswordConditions;


        [RelayCommand]
        private async Task AboutYouClicked()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
            await Shell.Current.GoToAsync(nameof(AboutYouPage));
        }

        public RegisterViewModel()
        {
        }
    }
}