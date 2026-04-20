using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class ContactShelterPage : ContentPage
{
	public ContactShelterPage()
	{
		InitializeComponent();
        BindingContext = new ContactShelterViewModel();
    }
}