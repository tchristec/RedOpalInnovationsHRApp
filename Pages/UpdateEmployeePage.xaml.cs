using RedOpalInnovationsHRApp.ViewModel;

namespace RedOpalInnovationsHRApp;

public partial class UpdateEmployeePage : ContentPage
{
    private Employee _selectedContact;
    public UpdateEmployeePage(Employee selectedContact)
    {
        InitializeComponent();
        _selectedContact = selectedContact;

        FirstNameEntry.Text = _selectedContact.FirstName;
        LastNameEntry.Text = _selectedContact.LastName;
        PhoneNumberEntry.Text = _selectedContact.PhoneNumber;
        DepartmentEntry.Text = _selectedContact.Department;
        StreetAddressEntry.Text = _selectedContact.StreetAddress;
        CityAddressEntry.Text = _selectedContact.CityAddress;
        StateAddressEntry.Text = _selectedContact.StateAddress;
        PostalCodeAddressEntry.Text =_selectedContact.PostalCodeAddress;
        CountryAddressEntry.Text = _selectedContact.Country;
    }

    private async void UpdateContact_Clicked(object sender, EventArgs e)
    {
        _selectedContact.FirstName = FirstNameEntry.Text;
        _selectedContact.LastName = LastNameEntry.Text;
        _selectedContact.PhoneNumber = PhoneNumberEntry.Text;
        _selectedContact.Department = DepartmentEntry.Text;
        _selectedContact.StreetAddress = StreetAddressEntry.Text;
        _selectedContact.CityAddress = CityAddressEntry.Text;
        _selectedContact.StateAddress = StateAddressEntry.Text;
        _selectedContact.PostalCodeAddress = PostalCodeAddressEntry.Text;
        _selectedContact.Country = CountryAddressEntry.Text;


        var result = await DisplayAlert("Update Contact", "Update contact details?", "Yes", "No");

        if (result)
        {
            await App.DatabaseService.UpdateEmployeeAsync(_selectedContact);
            Shell.Current.GoToAsync("//EmployeeListPage");
        }          
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        var selectedEmployee = _selectedContact;
        await Navigation.PushAsync(new EmployeeDetails(selectedEmployee));
    }
}