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
        //public string Layouts { get; set; } = TitleMain.Layouts;
        //public string Images { get; set; } = TitleMain.Images;
        //public string Collections { get; set; } = TitleMain.Collections;
        //public string Controls { get; set; } = TitleMain.Controls;
        //public string SQLLITE { get; set; } = TitleMain.SQLLite;

        [ObservableProperty]
        private string title = TitleMain.Title;

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
