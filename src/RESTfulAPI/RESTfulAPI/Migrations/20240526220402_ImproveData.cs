using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RESTfulAPI.Migrations
{
    /// <inheritdoc />
    public partial class ImproveData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2024, 6, 3, 1, 4, 0, 300, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2024, 6, 10, 1, 4, 0, 300, DateTimeKind.Local).AddTicks(4903));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2024, 6, 2, 20, 22, 32, 308, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2024, 6, 9, 20, 22, 32, 308, DateTimeKind.Local).AddTicks(9469));
        }
    }
}
