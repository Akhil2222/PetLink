using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class ContactShelterPage : ContentPage
{
	public ContactShelterPage(ContactShelterPage vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}