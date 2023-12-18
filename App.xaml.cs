namespace RedOpalInnovationsHRApp
{
    public partial class App : Application
    {

        public static DatabaseService DatabaseService { get; private set; }

        public App(DatabaseService db)
        {
            InitializeComponent();

            MainPage = new AppShell();

            DatabaseService = db;
        }
    }
}