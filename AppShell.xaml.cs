namespace RedOpalInnovationsHRApp;
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EmployeeListPage), typeof(EmployeeListPage));
        }
    }