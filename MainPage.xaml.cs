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

    }
}