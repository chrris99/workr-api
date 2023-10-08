using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutItems_WorkoutBlocks_WorkoutBlockWorkoutId_WorkoutBlo~",
                table: "WorkoutItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSets_WorkoutItems_WorkoutItemWorkoutBlockWorkoutId_W~",
                table: "WorkoutSets");

            migrationBuilder.RenameColumn(
                name: "WorkoutItemWorkoutBlockId",
                table: "WorkoutSets",
                newName: "WorkoutBlockId");

            migrationBuilder.RenameColumn(
                name: "WorkoutItemWorkoutBlockWorkoutId",
                table: "WorkoutSets",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "WorkoutBlockWorkoutId",
                table: "WorkoutItems",
                newName: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutItems_WorkoutBlocks_WorkoutId_WorkoutBlockId",
                table: "WorkoutItems",
                columns: new[] { "WorkoutId", "WorkoutBlockId" },
                principalTable: "WorkoutBlocks",
                principalColumns: new[] { "WorkoutId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSets_WorkoutItems_WorkoutId_WorkoutBlockId_WorkoutIt~",
                table: "WorkoutSets",
                columns: new[] { "WorkoutId", "WorkoutBlockId", "WorkoutItemId" },
                principalTable: "WorkoutItems",
                principalColumns: new[] { "WorkoutId", "WorkoutBlockId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutItems_WorkoutBlocks_WorkoutId_WorkoutBlockId",
                table: "WorkoutItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSets_WorkoutItems_WorkoutId_WorkoutBlockId_WorkoutIt~",
                table: "WorkoutSets");

            migrationBuilder.RenameColumn(
                name: "WorkoutBlockId",
                table: "WorkoutSets",
                newName: "WorkoutItemWorkoutBlockId");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "WorkoutSets",
                newName: "WorkoutItemWorkoutBlockWorkoutId");

            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "WorkoutItems",
                newName: "WorkoutBlockWorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutItems_WorkoutBlocks_WorkoutBlockWorkoutId_WorkoutBlo~",
                table: "WorkoutItems",
                columns: new[] { "WorkoutBlockWorkoutId", "WorkoutBlockId" },
                principalTable: "WorkoutBlocks",
                principalColumns: new[] { "WorkoutId", "Id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSets_WorkoutItems_WorkoutItemWorkoutBlockWorkoutId_W~",
                table: "WorkoutSets",
                columns: new[] { "WorkoutItemWorkoutBlockWorkoutId", "WorkoutItemWorkoutBlockId", "WorkoutItemId" },
                principalTable: "WorkoutItems",
                principalColumns: new[] { "WorkoutBlockWorkoutId", "WorkoutBlockId", "Id" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
