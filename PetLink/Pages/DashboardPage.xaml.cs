using PetLink.ViewModels;

namespace PetLink.Pages;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}