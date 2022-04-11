using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transactions").HasKey(transaction => transaction.Id);
            builder.Property(transaction => transaction.Date);
            builder.Property(transaction => transaction.PaymentMethod);
            builder.Property(transaction => transaction.TotalValue).HasColumnType("decimal(8,2)");

            builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.Transactions).HasForeignKey(transaction => transaction.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(transaction => transaction.TransactionLines).WithOne(transaction => transaction.Transaction).HasForeignKey(transactionLine  => transactionLine.TransactionID);    
        }
    }
}
