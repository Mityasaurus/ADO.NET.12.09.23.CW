using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _12._09._23.CW.Migrations
{
    /// <inheritdoc />
    public partial class DeletedTypeIntoProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerID",
                table: "Products",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeID",
                table: "Products",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerID",
                table: "Products",
                column: "ManufacturerID",
                principalTable: "Manufacturers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Types_TypeID",
                table: "Products",
                column: "TypeID",
                principalTable: "Types",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Types_TypeID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ManufacturerID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TypeID",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 9, 12, 19, 46, 43, 11, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 9, 12, 19, 46, 43, 11, DateTimeKind.Local).AddTicks(2585));
        }
    }
}
