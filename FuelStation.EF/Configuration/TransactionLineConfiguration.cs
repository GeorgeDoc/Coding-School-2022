using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configuration {
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("Transaction Lines").HasKey(tl => tl.Id);
            builder.Property(tl => tl.Quantity).HasColumnType("int");
            builder.Property(tl => tl.ItemPrice).HasColumnType("decimal(8,2)");
            builder.Property(tl => tl.NetValue).HasColumnType("decimal(8,2)");
            builder.Property(tl => tl.DiscountPercent).HasColumnType("decimal(5,2)");
            builder.Property(tl => tl.DiscountValue).HasColumnType("decimal(8,2)");
            builder.Property(tl => tl.TotalValue).HasColumnType("decimal(9,2)");

            builder.HasOne(tl => tl.Item).WithMany(item => item.TransactionLines).HasForeignKey(tl => tl.Item);
        }
    }
}
