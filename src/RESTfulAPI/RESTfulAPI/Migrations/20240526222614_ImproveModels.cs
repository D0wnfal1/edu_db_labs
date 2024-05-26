using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTfulAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImproveModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2024, 6, 3, 1, 26, 14, 597, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2024, 6, 10, 1, 26, 14, 597, DateTimeKind.Local).AddTicks(1673));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2024, 6, 3, 1, 11, 54, 417, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2024, 6, 10, 1, 11, 54, 417, DateTimeKind.Local).AddTicks(4590));
        }
    }
}
