using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    internal class ItemConfiguration : IEntityTypeConfiguration<Item> {
        public void Configure(EntityTypeBuilder<Item> builder) {
            builder.ToTable("Items").HasKey(item => item.Id);
            builder.Property(item => item.Code).HasMaxLength(10);
            builder.HasIndex(item => item.Code).IsUnique();
            builder.Property(item => item.Description).HasMaxLength(100);
            builder.Property(item => item.ItemType);
            builder.Property(item => item.Price).HasColumnType("decimal(8,2)");
            builder.Property(item => item.Cost).HasColumnType("decimal(8,2)");
        }
    }
}



