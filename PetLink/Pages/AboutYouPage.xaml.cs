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