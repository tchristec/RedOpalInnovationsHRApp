namespace RedOpalInnovationsHRApp;
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EmployeeListPage), typeof(EmployeeListPage));
            Routing.RegisterRoute(nameof(AddEmployeePage), typeof(AddEmployeePage));            
            Routing.RegisterRoute(nameof(EmployeeDetails), typeof(EmployeeDetails));
        }
    }