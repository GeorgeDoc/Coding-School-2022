using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Session_15_EF.Configuration {
    internal class ConfigTransaction : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();
        }
    }
}
