using SQLite;

public class DatabaseService
{
    SQLiteAsyncConnection _database;

    public DatabaseService() 
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db");
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Employee>().Wait();
    }

    #region CRUD Operations
    public async Task CreateEmployeeAsync(Employee employee) 
    {
        await _database.InsertAsync(employee);
    }

    public async Task<List<Employee>> ReadEmplyeeAsync() 
    {
        return await _database.Table<Employee>().ToListAsync();
    }

    public async Task UpdateEmployeeAsync(Employee employee) 
    {
        await _database.UpdateAsync(employee);
    }

    public async Task DeleteEmployeeAsync(Employee employee) 
    {
        await _database.DeleteAsync(employee);
    }
    #endregion


}