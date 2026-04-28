using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetLink.Models.Titles;

namespace PetLink.ViewModels;

public partial class AboutYouViewModel : ObservableObject
{
    public string Title => TitleAboutYou.Title;
    public string Instruction => TitleAboutYou.Instruction;
    public string SetToHalf => TitleAboutYou.SetToHalf;

    [ObservableProperty]
    private string entryTextPhone = "";

    [ObservableProperty]
    private string entryTextBirthDate = "";

    [ObservableProperty]
    private string entryTextZipcode = "";

    private double slider = 0.0;

    [RelayCommand]
    private void SetToHalfClicked()
    {
        slider = 0.5;
    }

    [RelayCommand]
    private async Task EntryClicked()
    {
        if (string.IsNullOrWhiteSpace(entryTextPhone))
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                         "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                             "You entered: " + entryTextPhone, "OK");
        }

        if (string.IsNullOrWhiteSpace(entryTextBirthDate))
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                         "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                             "You entered: " + entryTextBirthDate, "OK");
        }

        if (string.IsNullOrWhiteSpace(entryTextZipcode))
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                         "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert(TitleAboutYou.Title,
                                             "You entered: " + entryTextZipcode, "OK");
        }
    }

}

