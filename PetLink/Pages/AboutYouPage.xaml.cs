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
	string entryTextPhone = EntryValuePhone.Text;

    string entryTextBirthday = EntryValueBirthdate.Text;

    string entryTextZipcode = EntryValueZipcode.Text;


    if (string.IsNullOrEmpty(entryTextPhone))
	{
		await Shell.Current.DisplayAlert(TitleAboutYou.Title, "Entry is empty. Please enter text.", "OK");
	}

    if (string.IsNullOrEmpty(entryTextBirthday))
    {
        await Shell.Current.DisplayAlert(TitleAboutYou.Title, "Entry is empty. Please enter text.", "OK");
    }

    if (string.IsNullOrEmpty(entryTextZipcode))
    {
        await Shell.Current.DisplayAlert(TitleAboutYou.Title, "Entry is empty. Please enter text.", "OK");
    }
}