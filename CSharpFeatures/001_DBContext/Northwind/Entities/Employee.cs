namespace _001_DBContext.Northwind.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
}