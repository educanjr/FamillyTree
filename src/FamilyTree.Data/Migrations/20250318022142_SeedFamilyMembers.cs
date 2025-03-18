using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FamilyTree.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFamilyMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "BirthLocation", "DeathDate", "DeathLocation", "FamilyId", "Gender", "GivenName", "Surname" },
                values: new object[,]
                {
                    { new Guid("30e99d4d-4700-4c22-a1a3-ebdec1eb79b0"), null, "", new DateTime(2015, 8, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Los Angeles", new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"), "Female", "Jane", "Smith" },
                    { new Guid("5eeceddf-f9a2-4b7e-b236-2dba0000cdbf"), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Seattle", null, "", new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"), "Female", "Emma", "Johnson" },
                    { new Guid("69d3685a-3b75-4c32-86a0-1dfbb585c10a"), new DateTime(1910, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Chicago", null, "", new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"), "Male", "Robert", "Brown" },
                    { new Guid("a2a5bcfe-da88-46e7-8439-d8f5ec85c474"), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "New York", null, "", new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"), "Male", "John", "Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("30e99d4d-4700-4c22-a1a3-ebdec1eb79b0"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5eeceddf-f9a2-4b7e-b236-2dba0000cdbf"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("69d3685a-3b75-4c32-86a0-1dfbb585c10a"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("a2a5bcfe-da88-46e7-8439-d8f5ec85c474"));
        }
    }
}
