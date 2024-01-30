using Microsoft.EntityFrameworkCore;
using SadafBI.Models;
using System;
using System.Reflection.Emit;

namespace SadafBI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<SqlCustomersListModel> Customers { get; set; }
        public DbSet<SqlCustomergroup> Customergroups { get; set; }
        public DbSet<SqlDomain> Domains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=SadafBI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       

            modelBuilder.Entity<SqlCustomersListModel>()
                .Property(c => c.customerGroupId)
                .ValueGeneratedOnAdd(); // تعیین تولید مقدار خودکار برای کلید اصلی
            modelBuilder.Entity<SqlCustomersListModel>()
                             .HasOne(c => c.SqlDomain)
                             .WithMany()
                             .HasForeignKey(c => c.domainId)
                             .OnDelete(DeleteBehavior.Restrict);

  

            modelBuilder.Entity<SqlCustomersListModel>()
                .HasOne(c => c.SqlCustomergroup)
                .WithMany()
                .HasForeignKey(c => c.customerGroupId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

