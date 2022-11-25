using System;
using Microsoft.EntityFrameworkCore;

namespace LegitBankApp.Model
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=Legitbankapp;Uid=root;Pwd=Adebayo58641999");

        }
        public DbSet<Admin> Admin {get; set;}
         public DbSet<Customer> Customer {get; set;}
          public DbSet<ManagingDirector> managingDirector {get; set;}
           public DbSet<Transaction> Transaction {get; set;}




    }
    
}