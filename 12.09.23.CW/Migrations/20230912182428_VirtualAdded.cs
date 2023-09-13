using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _12._09._23.CW.Migrations
{
    /// <inheritdoc />
    public partial class VirtualAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 12, 21, 19, 0, 806, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 12, 21, 19, 0, 806, DateTimeKind.Local).AddTicks(8413));
        }
    }
}
