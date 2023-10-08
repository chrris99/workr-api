using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutTemplateKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutItemTemplates_WorkoutBlockTemplates_WorkoutBlockTemp~",
                table: "WorkoutItemTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSetTemplates_WorkoutItemTemplates_WorkoutItemTemplat~",
                table: "WorkoutSetTemplates");

            migrationBuilder.RenameColumn(
                name: "WorkoutItemTemplateWorkoutBlockTemplateId",
                table: "WorkoutSetTemplates",
                newName: "WorkoutBlockTemplateId");

            migrationBuilder.RenameColumn(
                name: "WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId",
                table: "WorkoutSetTemplates",
                newName: "WorkoutTemplateId");

            migrationBuilder.RenameColumn(
                name: "WorkoutBlockTemplateWorkoutTemplateId",
                table: "WorkoutItemTemplates",
                newName: "WorkoutTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutItemTemplates_WorkoutBlockTemplates_WorkoutTemplateI~",
                table: "WorkoutItemTemplates",
                columns: new[] { "WorkoutTemplateId", "WorkoutBlockTemplateId" },
                principalTable: "WorkoutBlockTemplates",
                principalColumns: new[] { "WorkoutTemplateId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSetTemplates_WorkoutItemTemplates_WorkoutTemplateId_~",
                table: "WorkoutSetTemplates",
                columns: new[] { "WorkoutTemplateId", "WorkoutBlockTemplateId", "WorkoutItemTemplateId" },
                principalTable: "WorkoutItemTemplates",
                principalColumns: new[] { "WorkoutTemplateId", "WorkoutBlockTemplateId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutItemTemplates_WorkoutBlockTemplates_WorkoutTemplateI~",
                table: "WorkoutItemTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSetTemplates_WorkoutItemTemplates_WorkoutTemplateId_~",
                table: "WorkoutSetTemplates");

            migrationBuilder.RenameColumn(
                name: "WorkoutBlockTemplateId",
                table: "WorkoutSetTemplates",
                newName: "WorkoutItemTemplateWorkoutBlockTemplateId");

            migrationBuilder.RenameColumn(
                name: "WorkoutTemplateId",
                table: "WorkoutSetTemplates",
                newName: "WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId");

            migrationBuilder.RenameColumn(
                name: "WorkoutTemplateId",
                table: "WorkoutItemTemplates",
                newName: "WorkoutBlockTemplateWorkoutTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutItemTemplates_WorkoutBlockTemplates_WorkoutBlockTemp~",
                table: "WorkoutItemTemplates",
                columns: new[] { "WorkoutBlockTemplateWorkoutTemplateId", "WorkoutBlockTemplateId" },
                principalTable: "WorkoutBlockTemplates",
                principalColumns: new[] { "WorkoutTemplateId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSetTemplates_WorkoutItemTemplates_WorkoutItemTemplat~",
                table: "WorkoutSetTemplates",
                columns: new[] { "WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId", "WorkoutItemTemplateWorkoutBlockTemplateId", "WorkoutItemTemplateId" },
                principalTable: "WorkoutItemTemplates",
                principalColumns: new[] { "WorkoutBlockTemplateWorkoutTemplateId", "WorkoutBlockTemplateId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
