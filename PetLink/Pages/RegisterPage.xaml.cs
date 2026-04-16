using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
        BindingContext = new RegisterViewModel();
    }

    private async void RegisterSubmitClicked(object sender, EventArgs e)
    {
        string firstName = FirstNameValue.Text;
        string lastName = LastNameValue.Text;
        string username = UserNameValue.Text;
        string password = PasswordValue.Text;
        string confirmPassword = ConfirmPasswordValue.Text;

        if (string.IsNullOrWhiteSpace(firstName))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }

        if (string.IsNullOrWhiteSpace(username))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }

        if (string.IsNullOrWhiteSpace(confirmPassword))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }
    }
}