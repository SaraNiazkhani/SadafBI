using Microsoft.EntityFrameworkCore;
using SadafBI.CustomersList.Models;
using SadafBI.SeperateTransactionInformation.Models;
using System;
using System.Reflection.Emit;

namespace SadafBI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<SqlCustomersListModel> Customers { get; set; }
        public DbSet<SqlCustomergroup> Customergroups { get; set; }
        public DbSet<SqlDomain> Domains { get; set; }
        public DbSet<SqlSeparateTransactionModel> SeparateTransaction { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SqlCustomersListModel>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlCustomergroup>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlDomain>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlSeparateTransactionModel>().HasKey(c => c.Id);



            modelBuilder.Entity<SqlCustomersListModel>()
                             .HasOne(c => c.SqlDomain)
                             .WithMany(b=>b.Customers)
                             .HasForeignKey(c => c.domain_Id);
                           



            modelBuilder.Entity<SqlCustomersListModel>()
                .HasOne(c => c.SqlCustomergroup)
                .WithMany(b => b.Customers)
                .HasForeignKey(c => c.customerGroup_Id);
               
        }
    }
}

