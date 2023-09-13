using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _12._09._23.CW.Migrations
{
    /// <inheritdoc />
    public partial class InsertTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Manufacturer 1" },
                    { 2, "Manufacturer 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CostPrice", "Date", "ManufacturerID", "Name", "Number", "TypeID" },
                values: new object[,]
                {
                    { 1, 18, new DateTime(2023, 9, 12, 19, 46, 43, 11, DateTimeKind.Local).AddTicks(2547), 1, "Product 1", 75, 2 },
                    { 2, 80, new DateTime(2023, 9, 12, 19, 46, 43, 11, DateTimeKind.Local).AddTicks(2585), 2, "Product 2", 140, 1 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Type 1" },
                    { 2, "Type 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
