using Lingua_Flash.Pages.Sessions;

namespace Lingua_Flash
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Session), typeof(Session));
        }
    }
}