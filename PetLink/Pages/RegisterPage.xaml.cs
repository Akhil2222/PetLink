using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}