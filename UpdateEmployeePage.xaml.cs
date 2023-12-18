using RedOpalInnovationsHRApp.ViewModel;

namespace RedOpalInnovationsHRApp;

public partial class UpdateEmployeePage : ContentPage
{
    public UpdateEmployeePage(UpdateEmployeeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void UpdateContact_Clicked(object sender, EventArgs e)
    {
        var employee = new Employee
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


        var selectedEmployee = (Employee)(((Button)sender).BindingContext);
        bool result = await DisplayAlert("Update Contact", "Update contact details?", "Yes", "No");

        if (result)
        {
            await App.DatabaseService.UpdateEmployeeAsync(selectedEmployee);
            Shell.Current.GoToAsync("//EmployeeListPage");
        }
    }

    private void Back_Clicked(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync("//EmployeeListPage");
    }
}