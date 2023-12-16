using CommunityToolkit.Mvvm.ComponentModel;

namespace RedOpalInnovationsHRApp.ViewModel;

public partial class MainViewModel : ObservableObject 
{
    [ObservableProperty]
    string text;
}