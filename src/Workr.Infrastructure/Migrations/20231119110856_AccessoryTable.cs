using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AccessoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("1adff2cf-f2ec-4c05-9f9b-70cad12caa98"), "Barbell", true },
                    { new Guid("23ea38b8-49f2-463f-a212-9b216256b422"), "Kettlebell", true }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("28fc4803-de23-4d56-8a55-0509cb7d2c2d"), "JumpRope" },
                    { new Guid("3207f226-e0c6-416b-8a79-39efcdbc33d6"), "Bike" },
                    { new Guid("508ad1c9-7ada-48ae-9e0b-a455354f9cf4"), "Treadmill" },
                    { new Guid("c6b0b90c-6606-4941-82d2-56d81fc7f44c"), "Bar" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("ea8976e5-bd2c-4abb-a77c-70ff48ffb60c"), "Dumbbell", true });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_Name",
                table: "Accessories",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");
        }
    }
}
