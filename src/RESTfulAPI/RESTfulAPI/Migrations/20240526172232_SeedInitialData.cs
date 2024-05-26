using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RESTfulAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Details", "Name" },
                values: new object[,]
                {
                    { 1, "Details of Project 1", "Project 1" },
                    { 2, "Details of Project 2", "Project 2" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description of Team 1", "Team 1" },
                    { 2, "Description of Team 2", "Team 2" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTeams",
                columns: new[] { "ProjectId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Deadline", "Details", "ProjectId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 2, 20, 22, 32, 308, DateTimeKind.Local).AddTicks(9424), "Details of Task 1", 1, "Task 1" },
                    { 2, new DateTime(2024, 6, 9, 20, 22, 32, 308, DateTimeKind.Local).AddTicks(9469), "Details of Task 2", 2, "Task 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectTeams",
                keyColumns: new[] { "ProjectId", "TeamId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectTeams",
                keyColumns: new[] { "ProjectId", "TeamId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
