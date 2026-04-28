using PetLink.Pages;


namespace PetLink
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            //Main Page
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            //Register Page
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));

            //AboutYou Page
            //Routing.RegisterRoute(nameof(AboutYouPage), typeof(AboutYouPage));

            //Login Page
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));

            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(FindMyPetPage), typeof(FindMyPetPage));
            Routing.RegisterRoute(nameof(LikedPetsPage), typeof(LikedPetsPage));
            Routing.RegisterRoute(nameof(PetProfilePage), typeof(PetProfilePage));
            Routing.RegisterRoute(nameof(ContactShelterPage), typeof(ContactShelterPage));
        }
    }
}