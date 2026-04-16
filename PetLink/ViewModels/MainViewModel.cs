using Android.Text.Style;
using AndroidX.RecyclerView.Widget;
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
        public string Title { get; set; } = TitleMain.Title;
        public string Login { get; set; } = TitleMain.Login;
        public string Register { get; set; } = TitleMain.Register;

        [RelayCommand]
        private async Task LoginClicked()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }

        public MainViewModel()
        {

        }
    }
}
