using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class AboutYouPage : ContentPage
{
	public AboutYouPage(AboutYouViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}