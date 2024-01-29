using Microsoft.EntityFrameworkCore;
using SadafBI.Models;
using System;

namespace SadafBI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<SqlCustomerList> Customers { get; set; }
        public DbSet<SqlCustomergroup> Customergroups { get; set; }
        public DbSet<SqlDomain> Domains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SqlCustomerList>().HasKey(c => c.customerId);
            modelBuilder.Entity<SqlDomain>().HasKey(c => c.domainId);
            modelBuilder.Entity<SqlCustomergroup>().HasKey(c => c.customerGroupId);
      
        }
    }
}
