using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Pages;

public AboutYouPage()
{
	InitializeComponent();
	BindingContext = new AboutYouViewModel();
}

private async void SubmitClicked(object sender, EventArgs e)
{
	string entryText = EntryValue.Text;

	if (string.IsNullOrEmpty(entryText))
	{
		await Shell.Current.DisplayAlert(TitleAboutYou.Title, "Entry is empty. Please enter text.", "OK");
	}
}