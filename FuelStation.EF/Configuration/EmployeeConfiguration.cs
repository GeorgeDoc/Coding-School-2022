using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee> {
        
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employees").HasKey(employee => employee.Id);
            builder.Property(employee => employee.Name).IsRequired().HasMaxLength(50);
            builder.Property(employee => employee.Surname).IsRequired().HasMaxLength(50);
            builder.Property(employee => employee.EmployeeType).IsRequired();
            builder.Property(employee => employee.SallaryPerMonth).IsRequired().HasColumnType("decimal(8,2)");
        }
    }
}
