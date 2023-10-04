using Lingua_Flash.Pages.Sessions;

namespace Lingua_Flash
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoadSession(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Session());
        }
        /*
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = userNameEntry.Text;
            string password = passwordEntry.Text;

            if(Authenticate(username, password))
            {
                messageLabel.Text = "Login successful!";
            }
            else
            {
                messageLabel.Text = "Login failed. Please check creditentials.";
            }
        }

        private bool Authenticate(string username, string password)
        {
            return true;
        }
        */
    }
}