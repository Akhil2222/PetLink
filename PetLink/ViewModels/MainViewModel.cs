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
        //public string Layouts { get; set; } = TitleMain.Layouts;
        //public string Images { get; set; } = TitleMain.Images;
        //public string Collections { get; set; } = TitleMain.Collections;
        //public string Controls { get; set; } = TitleMain.Controls;
        //public string SQLLITE { get; set; } = TitleMain.SQLLite;

        [ObservableProperty]
        private string title = TitleMain.Title;

        //public ICommand OnLayoutsClicked { get; set; }
        //public MainViewModel()
        //{
        //    Title = TitleMain.Title;

        //    OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        //}

        //private async void OnLayoutsClickedAsync()
        //{
        //    await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        //}

        

        [RelayCommand]
        private async Task ControlsClicked()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        public MainViewModel()
        {

        }
    }
}
