namespace RedOpalInnovationsHRApp;

public partial class EmployeeDetails : ContentPage
{
    public EmployeeDetails(Employee employee)
	{
		InitializeComponent();
		BindingContext = employee;
	}

    private void OnBackTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EmployeeListPage");
    }

    private async void OnEditTapped(object sender, EventArgs e)
    {
        var selectedEmployee = (Employee)((Button)sender).BindingContext;
        await Navigation.PushAsync(new UpdateEmployeePage(selectedEmployee));
    }

}