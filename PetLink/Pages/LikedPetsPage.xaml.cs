using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class LikedPetsPage : ContentPage
{
	public LikedPetsPage()
	{
		InitializeComponent();
		BindingContext = new LikedPetsViewModel();
    }
}