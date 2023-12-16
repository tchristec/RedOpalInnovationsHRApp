using RedOpalInnovationsHRApp.ViewModel;
using SQLite;

namespace RedOpalInnovationsHRApp
{
    public partial class EmployeeListPage : ContentPage
    {
        private DatabaseService _databaseService;

        private List<Employee> _employees;
        public EmployeeListPage()
        {
            InitializeComponent();

            _databaseService = new DatabaseService();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadEmployeesAsync();
        }

        private async void UpdateEmployee_Clicked(object sender, EventArgs e) 
        {
            var selectedEmployee = (Employee)((Button)sender).BindingContext;
            await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
        }

        private async void DeleteEmployee_Clicked(Object sender, EventArgs e) 
        {
            var selectedEmployee = (Employee)(((Button)sender).BindingContext);
            bool result = await DisplayAlert("Delete Contact", "Delete this contact?", "Yes", "No");

            if (result) 
            {
                await _databaseService.DeleteEmployeeAsync(selectedEmployee);
                LoadEmployeesAsync();
            }
        }

        private async void ViewDetails_Clicked(object sender, EventArgs e) 
        {
            var selectedEmployee = (Employee)((Button)sender).BindingContext;
            await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
        }

        private async void LoadEmployeesAsync() 
        {
            try 
            {
                _employees = await _databaseService.ReadEmplyeeAsync();
                EmployeeListView.ItemsSource = _employees;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void OnAddContactTapped(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//AddEmployeePage");
        }

    }
}