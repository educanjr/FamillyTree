using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyTree.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedFamily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Famillies",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"), "Smith Family Tree" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Famillies",
                keyColumn: "Id",
                keyValue: new Guid("0a0a041f-dbf7-46bc-92e2-825d07d92d3c"));
        }
    }
}
