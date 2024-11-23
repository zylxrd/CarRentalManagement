using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3502), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3513), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3517), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3735), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3735), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3738), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3738), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3828), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3830), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3830), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3832), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3833), new DateTime(2024, 11, 18, 17, 18, 6, 55, DateTimeKind.Local).AddTicks(3833), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
