using RedOpalInnovationsHRApp.ViewModel;
using SQLite;

namespace RedOpalInnovationsHRApp;

public partial class AddEmployeePage : ContentPage
{
	//private DatabaseService _databaseService;

	//private List<Employee> _employees;

	public AddEmployeePage()
	{
		InitializeComponent();

		//_databaseService = new DatabaseService();
	}

  //  protected override void OnAppearing()
  //  {
  //      base.OnAppearing();

		//LoadEmployeesAsync();
  //  }

	//private async void UpdateEmployee_Clicked(object sender, EventArgs e) 
	//{
	//	var selectedEmployee = (Employee)((Button)sender).BindingContext;
	//	await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
	//}

	//private async void DeleteEmployee_Clicked(Object sender, EventArgs e) 
	//{
	//	var selectedEmployee = (Employee)((Button)sender).BindingContext;
	//	bool result = await DisplayAlert("Delete Employee", "Delete this entry?", "Yes", "No");

	//	if (result) 
	//	{
	//		await _databaseService.DeleteEmployeeAsync(selectedEmployee);
	//		LoadEmployeesAsync();
	//	}
	//}

	//private async void ViewDetails_Clicked(object sender, EventArgs e) 
	//{
	//	var selectedEmployee = (Employee)((Button)sender).BindingContext;
	//	await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
	//}

	//private async void LoadEmployeesAsync() 
	//{
	//	try 
	//	{
	//		_employees = await _databaseService.ReadEmplyeeAsync();
	//		AddEmployeeView.ItemsSource = _employees;
	//	}
	//	catch (Exception ex) 
	//	{
	//		Console.WriteLine($"Exception: {ex}");
	//	}
	//}

	// Add new Employee

	private async void AddEmployee_Clicked(object sender, EventArgs e) 
	{
		var newEmployee = new Employee
		{
			FirstName = FirstNameEntry.Text, LastName = LastNameEntry.Text,
			PhoneNumber = PhoneNumberEntry.Text, Department = DepartmentEntry.Text,
			StreetAddress = StreetAddressEntry.Text, CityAddress = CityAddressEntry.Text,
			StateAddress = StateAddressEntry.Text, PostalCodeAddress = PostalCodeAddressEntry.Text,
			Country = CountryAddressEntry.Text
		};

		await _databaseService.CreateEmployeeAsync(newEmployee);

		FirstNameEntry.Text = LastNameEntry.Text = PhoneNumberEntry.Text = DepartmentEntry.Text
			= StreetAddressEntry.Text = CityAddressEntry.Text = StateAddressEntry.Text
			= PostalCodeAddressEntry.Text = CountryAddressEntry.Text = string.Empty;
		LoadEmployeesAsync();
	}

    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//EmployeeListPage");
    }
}