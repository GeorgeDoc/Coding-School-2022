﻿// <auto-generated />
using System;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuelStation.EF.Migrations
{
    [DbContext(typeof(FuelStationContext))]
    partial class FuelStationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FuelStation.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CardNumber")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("FuelStation.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HireDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HireDateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SallaryPerMonth")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("FuelStation.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Items", (string)null);
                });

            modelBuilder.Entity("FuelStation.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("FuelStation.Models.TransactionLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("DiscountValue")
                        .HasColumnType("decimal(8,2)");

                    b.Property<Guid>("ItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("NetValue")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(9,2)");

                    b.Property<Guid>("TransactionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ItemID");

                    b.HasIndex("TransactionID");

                    b.ToTable("Transaction Lines", (string)null);
                });

            modelBuilder.Entity("FuelStation.Models.Transaction", b =>
                {
                    b.HasOne("FuelStation.Models.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FuelStation.Models.Employee", "Employee")
                        .WithMany("Transactions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FuelStation.Models.TransactionLine", b =>
                {
                    b.HasOne("FuelStation.Models.Item", "Item")
                        .WithMany("TransactionLines")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FuelStation.Models.Transaction", "Transaction")
                        .WithMany("TransactionLines")
                        .HasForeignKey("TransactionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FuelStation.Models.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FuelStation.Models.Employee", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FuelStation.Models.Item", b =>
                {
                    b.Navigation("TransactionLines");
                });

            modelBuilder.Entity("FuelStation.Models.Transaction", b =>
                {
                    b.Navigation("TransactionLines");
                });
#pragma warning restore 612, 618
        }
    }
}