using Microsoft.EntityFrameworkCore;
using SadafBI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.Data
{
    public class DataContext: DbContext
    {
        public DbSet<CustomersModel> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;");
        }
    }
}
