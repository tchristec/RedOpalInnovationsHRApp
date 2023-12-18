using SQLite;

public class Employee 
{
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Department { get; set; }
    public string StreetAddress { get; set; }
    public string CityAddress { get; set; }
    public string StateAddress { get; set; }
    public string PostalCodeAddress { get; set; }
    public string Country { get; set; }
}