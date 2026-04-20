using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class AboutYouXAML : ContentPage
{
	public AboutYouXAML()
	{
		InitializeComponent();
        BindingContext = new AboutYouViewModel();
    }
}