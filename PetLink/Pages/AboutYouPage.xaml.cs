using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class AboutYouPage : ContentPage
{
    public AboutYouPage()
    {
        InitializeComponent();
        BindingContext = new AboutYouViewModel();
    }
}
