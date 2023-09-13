using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _12._09._23.CW.Migrations
{
    /// <inheritdoc />
    public partial class InsertedNewProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 13, 12, 15, 16, 993, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 13, 12, 15, 16, 993, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CostPrice", "Date", "ManufacturerID", "Name", "Number", "TypeID" },
                values: new object[] { 3, 15, new DateTime(2023, 9, 13, 12, 15, 16, 993, DateTimeKind.Local).AddTicks(1155), 2, "New Product 3", 480, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 12, 21, 24, 28, 40, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 12, 21, 24, 28, 40, DateTimeKind.Local).AddTicks(4105));
        }
    }
}
