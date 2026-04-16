using CommunityToolkit.Mvvm.ComponentModel;
using Javax.Security.Auth;
using PetLink.Models.Titles;

namespace PetLink.ViewModels;

public class AboutYouViewModel : ContentView
{
	public partial class AboutYouViewModel : ObservableObject
	{
		[ObservableProperty]
		private string title = TitleAboutYou.Title;
	}
}