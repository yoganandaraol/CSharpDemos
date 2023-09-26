using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DBContext.Northwind
{
    public class NorthwindDbContextFactory
    {
        private static DbContextOptions<NorthwindDbContext> _options;
        static NorthwindDbContextFactory() 
        {
            _options = new DbContextOptionsBuilder<NorthwindDbContext>()
                .UseSqlServer("Server=DESKTOP-91G2FL9;Database=Northwind;User Id=sa;Password=Reswanya@2014;TrustServerCertificate=True")
                .Options;
        }

        public static NorthwindDbContext Create()
        {
            var dbContext = new NorthwindDbContext(_options);
            return dbContext;
        }
    }
}
