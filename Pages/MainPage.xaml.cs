using RedOpalInnovationsHRApp.ViewModel;

namespace RedOpalInnovationsHRApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void OnLoginTapped(object sender, EventArgs e) 
        {
            Shell.Current.GoToAsync("//EmployeeListPage");
        }

        private void OnExitTapped(object sender, EventArgs e) 
        {
            Application.Current.Quit();
        }

        private void OnSettingsTapped(object sender, TappedEventArgs e)
        {
            Shell.Current.GoToAsync("//SettingsPage");
        }
    }
}