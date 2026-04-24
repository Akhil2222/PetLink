using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class LikedPetsPage : ContentPage
{
    public LikedPetsPage(LikedPetsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}