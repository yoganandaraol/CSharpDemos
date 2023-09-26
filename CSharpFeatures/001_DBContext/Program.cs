using _001_DBContext.Northwind;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace _001_DBContext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = NorthwindDbContextFactory.Create();
            var employees = dbContext.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}\t{emp.LastName}\t{emp.Title}");
            }

            //try
            //{
            //    SqlConnection con = new SqlConnection("Server=DESKTOP-91G2FL9;Database=Northwind;User Id=sa;Password=Reswanya@2014;TrustServerCertificate=True");
            //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    foreach (DataRow employee in ds.Tables[0].Rows)
            //    {
            //        Console.WriteLine(employee["FirstName"]);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.ReadLine();
        }
    }
}