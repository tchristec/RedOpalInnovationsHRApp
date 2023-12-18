namespace RedOpalInnovationsHRApp;

public partial class EmployeeListPage : ContentPage
{
    private List<Employee> _employees;
    public EmployeeListPage()
    {
        InitializeComponent();
        LoadEmployeesAsync();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        LoadEmployeesAsync();
    }

    private async void UpdateEmployee_Clicked(object sender, EventArgs e) 
    {
        var selectedEmployee = (Employee)((SwipeItem)sender).BindingContext;
        await Navigation.PushAsync(new UpdateEmployeePage(selectedEmployee));
    }

    private async void DeleteEmployee_Clicked(Object sender, EventArgs e) 
    {
        var selectedEmployee = (Employee)(((SwipeItem)sender).BindingContext);
        bool result = await DisplayAlert("Delete Contact", "Delete this contact?", "Yes", "No");

        if (result) 
        {
            await App.DatabaseService.DeleteEmployeeAsync(selectedEmployee);
            LoadEmployeesAsync();

        }
    }

    private async void ViewDetails_Clicked(object sender, EventArgs e) 
    {
        var selectedEmployee = (Employee)((SwipeItem)sender).BindingContext;
        await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
    }

    private void OnAddContactTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//AddEmployeePage");
    }

    private async void LoadEmployeesAsync() 
    {
        try 
        {
            _employees = await App.DatabaseService.ReadEmployeesAsync();
            contactsList.ItemsSource = _employees;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}