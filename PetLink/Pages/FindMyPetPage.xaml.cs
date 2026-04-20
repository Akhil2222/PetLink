using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class FindMyPetPage : ContentPage
{
	public FindMyPetPage(FindMyPetViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}