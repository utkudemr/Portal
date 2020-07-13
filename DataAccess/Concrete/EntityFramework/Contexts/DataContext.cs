using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Reflection;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class DataContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LAEV069;Initial Catalog=Portal;Integrated Security=True");
      
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(s => s.Tc).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(s => s.Firstname).IsRequired().HasMaxLength(70);
            modelBuilder.Entity<Customer>().Property(s => s.Lastname).IsRequired().HasMaxLength(70);
            modelBuilder.Entity<Customer>().Property(s => s.Dateofbirth).IsRequired();
            modelBuilder.Entity<Customer>().Property(s => s.CompanyId).IsRequired();
            modelBuilder.Entity<Company>().Property(s => s.Name).IsRequired().HasMaxLength(50);


        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customer> Customer { get; set; }


    }
}
