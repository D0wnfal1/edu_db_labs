using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTfulAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImproveTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2024, 6, 3, 1, 6, 37, 587, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2024, 6, 10, 1, 6, 37, 587, DateTimeKind.Local).AddTicks(3404));
        }
    }
}
