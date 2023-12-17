namespace RedOpalInnovationsHRApp;

public partial class AddEmployeePage : ContentPage
{
	public AddEmployeePage()
	{
		InitializeComponent();
	}

	private void Back_Clicked(object sender, EventArgs e)
    {
        
        Shell.Current.GoToAsync("//EmployeeListPage");
    }

    private async void AddContact_Clicked(object sender, EventArgs e)
    {
        var newEmployee = new Employee
        {
            FirstName = FirstNameEntry.Text,
            LastName = LastNameEntry.Text,
            PhoneNumber = PhoneNumberEntry.Text,
            Department = DepartmentEntry.Text,
            StreetAddress = StreetAddressEntry.Text,
            CityAddress = CityAddressEntry.Text,
            StateAddress = StateAddressEntry.Text,
            PostalCodeAddress = PostalCodeAddressEntry.Text,
            Country = CountryAddressEntry.Text
        };

        await App.DatabaseService.CreateEmployeeAsync(newEmployee);

        FirstNameEntry.Text = LastNameEntry.Text = PhoneNumberEntry.Text = DepartmentEntry.Text
            = StreetAddressEntry.Text = CityAddressEntry.Text = StateAddressEntry.Text
            = PostalCodeAddressEntry.Text = CountryAddressEntry.Text = string.Empty;

        Shell.Current.GoToAsync("//EmployeeListPage");
    }
}