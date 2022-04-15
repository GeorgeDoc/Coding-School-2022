using Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    public class ConfigProduct : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.ToTable("Product");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(product => product.Description).HasMaxLength(300);
            builder.Property(product => product.Description).IsRequired(true);
            builder.Property(product => product.Code).IsRequired(true).HasMaxLength(5);
            builder.Property(product => product.Price).IsRequired(true);
            builder.Property(product => product.Cost).IsRequired(true);


        }
    }
}
