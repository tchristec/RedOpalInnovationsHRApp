using SQLite;

namespace RedOpalInnovationsHRApp
{
    public class DatabaseService
    {
        string _dbPath;
        public SQLiteAsyncConnection _dbConnection;

        public DatabaseService(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async void Init()
        {
            _dbConnection = new SQLiteAsyncConnection(_dbPath);
            await _dbConnection.CreateTableAsync<Employee>();
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _dbConnection.InsertAsync(employee);
        }

        public async Task<List<Employee>> ReadEmployeesAsync()
        {
            List<Employee> employees = new List<Employee>();

            Init();
            try
            {
                employees = await _dbConnection.Table<Employee>().ToListAsync();
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return employees;
            }
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await _dbConnection.UpdateAsync(employee);
        }

        public async Task DeleteEmployeeAsync(Employee employee)
        {
            await _dbConnection.DeleteAsync(employee);
        }
    }
}
