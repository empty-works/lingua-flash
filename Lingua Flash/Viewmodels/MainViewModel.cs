using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lingua_Flash.Pages.Sessions;
using System.ComponentModel;

namespace Lingua_Flash.Viewmodels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task LoadSession()
    {
        await Shell.Current.GoToAsync(nameof(Session));
    }
}
