using Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15_EF.Configuration {
    internal class ConfigEmployee : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Empmloyee");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();

            builder.Property(employee => employee.Name).HasMaxLength(40).IsRequired(true);
            builder.Property(employee => employee.Surname).HasMaxLength(40).IsRequired(true);
        }
    }
}
