namespace RedOpalInnovationsHRApp;
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EmployeeListPage), typeof(EmployeeListPage));
            Routing.RegisterRoute(nameof(AddEmployeePage), typeof(AddEmployeePage));            
            Routing.RegisterRoute(nameof(EmployeeDetails), typeof(EmployeeDetails));
            Routing.RegisterRoute(nameof(UpdateEmployeePage), typeof(UpdateEmployeePage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        }
    }