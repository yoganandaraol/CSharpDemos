using Microsoft.EntityFrameworkCore;
using _001_DBContext.Northwind.Entities;

namespace _001_DBContext.Northwind;

public class NorthwindDbContext : DbContext
{
	public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
	{
	}

	public DbSet<Employee> Employees { get; set; }
}
