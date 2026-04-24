using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}