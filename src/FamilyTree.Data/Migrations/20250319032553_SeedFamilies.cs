using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FamilyTree.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFamilies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Famillies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"), "Baggins Family" },
                    { new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"), "Brown Family" },
                    { new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"), "Johnson Family" },
                    { new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"), "Smith Family" },
                    { new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"), "Potter Family" },
                    { new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Atreides Family" },
                    { new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"), "Gonzalez Family" },
                    { new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"), "Williams Family" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("a3f7b92d-6c5e-4d12-8125-7b3a6f8d2e64"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("a5b8c72d-4f99-4e42-8913-6d7f31c8b2e1"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("a9f6214b-3f8e-4b4c-857b-5dba5d1a3f43"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("b1a8e62d-4499-4f34-8773-b9fa4e7d2c43"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("b3e7c92d-5f4c-4d12-8925-6b7f31a8d2e6"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("c1a9d72b-4f8c-4e92-8d7a-6b2f3e5c7a81"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("c1d9a72b-4f8c-4e92-8d7a-6b2f3e5c7a81"));

            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("f2a19d5c-3b4e-4d92-8827-6f5b2e34c812"));
        }
    }
}
