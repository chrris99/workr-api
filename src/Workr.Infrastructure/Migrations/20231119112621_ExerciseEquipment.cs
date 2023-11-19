using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("1adff2cf-f2ec-4c05-9f9b-70cad12caa98"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("23ea38b8-49f2-463f-a212-9b216256b422"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("28fc4803-de23-4d56-8a55-0509cb7d2c2d"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("3207f226-e0c6-416b-8a79-39efcdbc33d6"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("508ad1c9-7ada-48ae-9e0b-a455354f9cf4"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("c6b0b90c-6606-4941-82d2-56d81fc7f44c"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("ea8976e5-bd2c-4abb-a77c-70ff48ffb60c"));

            migrationBuilder.CreateTable(
                name: "EquipmentExercise",
                columns: table => new
                {
                    EquipmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExercisesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentExercise", x => new { x.EquipmentId, x.ExercisesId });
                    table.ForeignKey(
                        name: "FK_EquipmentExercise_Accessories_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentExercise_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("001cb876-cdf6-4625-a2f0-2c414f953ef8"), "Barbell", true });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1267a8b7-120b-456a-a4f2-f9853338260e"), "Treadmill" });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("383fb7ac-1f4a-4bf7-9cbb-1cef985c29eb"), "Dumbbell", true });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4b1ffdc4-53ff-4ef0-acdf-e4496e3abf82"), "Bike" },
                    { new Guid("52d4c2b3-16a1-401d-8679-8a930b067f8c"), "Bar" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("84967d74-50c6-40e5-9199-30d97ff95e8d"), "Kettlebell", true });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("af1d8cde-512c-4e8c-87b4-5ef056a71a73"), "JumpRope" });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentExercise_ExercisesId",
                table: "EquipmentExercise",
                column: "ExercisesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentExercise");

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("001cb876-cdf6-4625-a2f0-2c414f953ef8"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("1267a8b7-120b-456a-a4f2-f9853338260e"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("383fb7ac-1f4a-4bf7-9cbb-1cef985c29eb"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("4b1ffdc4-53ff-4ef0-acdf-e4496e3abf82"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("52d4c2b3-16a1-401d-8679-8a930b067f8c"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("84967d74-50c6-40e5-9199-30d97ff95e8d"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("af1d8cde-512c-4e8c-87b4-5ef056a71a73"));

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
        }
    }
}
