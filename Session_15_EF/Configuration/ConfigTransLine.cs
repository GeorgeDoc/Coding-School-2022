using Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15_EF.Configuration {
    internal class ConfigTransLine : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLine");
            builder.HasKey(trl => trl.ID);
            builder.Property(trl => trl.ID).ValueGeneratedOnAdd();

            builder.Property(trl => trl.ProductID).IsRequired(true);
            builder.Property(trl => trl.Price).IsRequired(true);
            builder.Property(trl => trl.TotalPrice).IsRequired(true);
            builder.Property(trl => trl.TransID).IsRequired(true);
            
        }
    }
}
