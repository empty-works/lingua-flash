using Lingua_Flash.Viewmodels;

namespace Lingua_Flash.Pages.Sessions;

public partial class Session : ContentPage
{
	public Session() { }
	public Session(SessionPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}