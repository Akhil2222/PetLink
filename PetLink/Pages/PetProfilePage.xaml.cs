using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class PetProfilePage : ContentPage
{
	public PetProfilePage()
	{
		InitializeComponent();
		BindingContext = new PetProfileViewModel();
    }
}