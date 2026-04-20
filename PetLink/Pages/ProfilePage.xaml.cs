using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        BindingContext = new ProfileViewModel();
    }
}