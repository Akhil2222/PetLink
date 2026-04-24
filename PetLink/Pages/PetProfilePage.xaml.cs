using PetLink.View_Models;

namespace PetLink.Pages;

public partial class PetProfilePage : ContentPage
{
	public PetProfilePage(PetProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}