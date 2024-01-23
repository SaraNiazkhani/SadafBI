using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.Data
{
    public class DataContext : DbContext
    {
       
        public DbSet<SqlCustomerList> Customers { get; set; }
        public DbSet<SqlCustomergroup> Customergroups { get; set; }
        public DbSet<SqlDomain> Domains { get; set; }
        public DbSet<CustomerListResponse> Responses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           modelBuilder.Entity<CustomerListResponse>().HasNoKey();
        }
    }
}



       

 