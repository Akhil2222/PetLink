using Android.Text.Style;
using AndroidX.RecyclerView.Widget;
using PetLink.Models.Titles;
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
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        private async Task CollectionsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsPage));
        }

        [RelayCommand]
        private async Task ControlsClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsPage));
        }

        public MainViewModel()
        {

        }
    }
}
