using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RedOpalInnovationsHRApp.ViewModel
{
    public partial class UpdateEmployeeViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task BackSimple() 
        {
            await Shell.Current.GoToAsync("..", true);
        }

    }
}
