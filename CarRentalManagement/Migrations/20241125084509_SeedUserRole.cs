using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(402), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(406), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(408), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 11, 25, 16, 45, 8, 203, DateTimeKind.Local).AddTicks(410) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9025), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9133), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9136), new DateTime(2024, 11, 25, 16, 9, 33, 476, DateTimeKind.Local).AddTicks(9136) });
        }
    }
}
