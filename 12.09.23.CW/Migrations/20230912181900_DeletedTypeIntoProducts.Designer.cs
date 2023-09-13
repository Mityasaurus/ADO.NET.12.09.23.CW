﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _12._09._23.CW.Warehouse;

#nullable disable

namespace _12._09._23.CW.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20230912181900_DeletedTypeIntoProducts")]
    partial class DeletedTypeIntoProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Manufacturer 1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Manufacturer 2"
                        });
                });

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CostPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ManufacturerID");

                    b.HasIndex("TypeID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CostPrice = 18,
                            Date = new DateTime(2023, 9, 12, 21, 19, 0, 806, DateTimeKind.Local).AddTicks(8372),
                            ManufacturerID = 1,
                            Name = "Product 1",
                            Number = 75,
                            TypeID = 2
                        },
                        new
                        {
                            ID = 2,
                            CostPrice = 80,
                            Date = new DateTime(2023, 9, 12, 21, 19, 0, 806, DateTimeKind.Local).AddTicks(8413),
                            ManufacturerID = 2,
                            Name = "Product 2",
                            Number = 140,
                            TypeID = 1
                        });
                });

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Type", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Type 1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Type 2"
                        });
                });

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Product", b =>
                {
                    b.HasOne("_12._09._23.CW.Warehouse.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_12._09._23.CW.Warehouse.Models.Type", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("_12._09._23.CW.Warehouse.Models.Type", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
