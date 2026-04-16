using AndroidX.RecyclerView.Widget;
using PetLink.Views;

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
            Routing.RegisterRoute(nameof(AboutYouPage), typeof(AboutYouPage));
        }
    }
}
