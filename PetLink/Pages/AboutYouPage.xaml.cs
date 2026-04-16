using PetLink.Models.Titles;
using PetLink.ViewModels;

namespace PetLink.Views;

public AboutYouPage()
{
	InitializeComponent();
	BindingContext = new AboutYouViewModel();
    UpdateVisuals(MySlider.Value);
    SetPlatformPadding();
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

private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
                                  => UpdateVisuals(e.NewValue);

private void UpdateVisuals(double value)
{
    MyBox.Opacity = value;
    ValueLabel.Text = $"Value of the slider is {value:F2}";

    InfoLabel.Opacity = value;
}

private void SetPlatformPadding()
{
    if (DeviceInfo.Platform == DevicePlatform.iOS
        || DeviceInfo.Platform == DevicePlatform.Andriod)
    {
        Padding = new Thickness(25);
    }
    else
    {
        Padding = Thickness.Zero;
    }
}