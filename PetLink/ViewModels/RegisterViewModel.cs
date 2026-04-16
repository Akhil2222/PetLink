using Android.Database;
using AndroidX.RecyclerView.Widget;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleRegister.Title;


        [RelayCommand]
        private async Task AboutYouClicked()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
            await Shell.Current.GoToAsync(nameof(AboutYouPage));
        }
    }
}