using Microsoft.EntityFrameworkCore;
using SadafBI.CustomersList.Models;
using SadafBI.CustomerStockStatus.Models;
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
        public DbSet<SqlCustomerStock> CustomerStock { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=172.18.30.3;User ID=BI;Password=S@D@Fbi#R@dman1403;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=SadafBI;");
            //optionsBuilder.UseSqlServer("Server=Data Source=172.18.30.3;User ID=BI;Password=S@D@Fbi#R@dman1403;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Database=SadafBI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SqlCustomersListModel>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlCustomergroup>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlDomain>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlSeparateTransactionModel>().HasKey(c => c.Id);
            modelBuilder.Entity<SqlCustomerStock>().HasKey(c => c.Id);


            modelBuilder.Entity<SqlCustomersListModel>()
                             .HasOne(c => c.SqlDomain)
                             .WithMany(b => b.Customers)
                             .HasForeignKey(c => c.domain_Id);





            modelBuilder.Entity<SqlCustomersListModel>()
                .HasOne(c => c.SqlCustomergroup)
                .WithMany(b => b.Customers)
                .HasForeignKey(c => c.customerGroup_Id);
               
        }
    }
}

