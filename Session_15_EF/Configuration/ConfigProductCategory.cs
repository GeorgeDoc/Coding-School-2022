using Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15_EF.Configuration {
    internal class ConfigProductCategory : IEntityTypeConfiguration<ProductCategory> {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) {

            builder.ToTable("Product_Category");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();

            builder.Property(x => x.Description).HasMaxLength(300);
        }
    }
}
