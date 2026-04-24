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

        if (string.IsNullOrWhiteSpace(firstName)
            && string.IsNullOrWhiteSpace(lastName)
            && string.IsNullOrWhiteSpace(username)
            && string.IsNullOrWhiteSpace(password)
            && string.IsNullOrWhiteSpace(confirmPassword))
        {
            await Shell.Current.DisplayAlert(TitleRegister.Title, "Entry is empty. Please enter text.", "OK");
        }

        else
        {
            await Shell.Current.GoToAsync($"{nameof(AboutYouPage)}");
        }
    }

}