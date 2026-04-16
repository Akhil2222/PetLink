using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Views;

public AboutYouPage()
{
	InitializeComponent();
	BindingContext = new AboutYouViewModel();
}

private async void SubmitClicked(object sender, EventArgs e)
{
	string entryText = EntryValuePhone.Text;

	if (string.IsNullOrEmpty(entryText))
	{
		await Shell.Current.DisplayAlert(TitleAboutYou.Title, "Entry is empty. Please enter text.", "OK");
	}
}