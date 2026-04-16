using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Javax.Security.Auth;
using PetLink.Models.Titles;

namespace PetLink.ViewModels;

public partial class AboutYouViewModel : ObservableObject
{
	[ObservableProperty]
	private string title = TitleAboutYou.Title;

	[RelayCommand]
	private async Task AboutYouClicked()

}