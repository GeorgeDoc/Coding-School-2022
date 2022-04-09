using FuelStation.EF.Configuration;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Context {
    public class FuelStationContext : DbContext {

        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { // hook την ώρα που φτιάχνει το μοντέλο.
            base.OnModelCreating(modelBuilder);                              // ότι έγραψα στο configurtation μπορώ να το γράψω εδώ, αλλά θα γίνει too much
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { //configure τη βάση
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source=LAPTOP-97BN5M6S\GEORGE;Initial Catalog = FuelStationDB; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
