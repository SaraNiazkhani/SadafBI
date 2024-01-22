using Microsoft.EntityFrameworkCore;
using SadafBI.Models;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           modelBuilder.Entity<SqlCustomerList>().HasNoKey();
        }
    }
}



       

 