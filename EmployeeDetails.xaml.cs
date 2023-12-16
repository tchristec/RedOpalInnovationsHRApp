namespace RedOpalInnovationsHRApp;

public partial class EmployeeDetails : ContentPage
{
	public EmployeeDetails(Employee employee)
	{
		InitializeComponent();
		BindingContext = employee;
	}
}