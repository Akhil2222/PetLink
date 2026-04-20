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
            Routing.RegisterRoute(nameof(AboutYouPage), typeof(AboutYouPage));

        }
    }
}
