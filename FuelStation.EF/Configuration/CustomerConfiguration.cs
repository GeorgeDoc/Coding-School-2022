using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {

            builder.ToTable("Customer").HasKey(customer => customer.Id);
            builder.Property(customer => customer.Name).IsRequired().HasMaxLength(50);      // by convention, required is redundand since I haven't defined 
            builder.Property(customer => customer.Surname).IsRequired().HasMaxLength(50);   // the properties as nullable, but I'm leaving it in anyway
            builder.Property(customer => customer.CardNumber).IsRequired().HasMaxLength(50);
            builder.HasIndex(customer => customer.CardNumber).IsUnique();
        }
    }
}
