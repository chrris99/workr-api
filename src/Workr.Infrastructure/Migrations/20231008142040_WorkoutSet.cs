using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reps",
                table: "WorkoutItemTemplates");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "WorkoutItemTemplates");

            migrationBuilder.DropColumn(
                name: "Reps",
                table: "WorkoutItems");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "WorkoutItems");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "WorkoutItems");

            migrationBuilder.CreateTable(
                name: "WorkoutSets",
                columns: table => new
                {
                    WorkoutItemWorkoutBlockWorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutItemWorkoutBlockId = table.Column<int>(type: "integer", nullable: false),
                    WorkoutItemId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSets", x => new { x.WorkoutItemWorkoutBlockWorkoutId, x.WorkoutItemWorkoutBlockId, x.WorkoutItemId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutSets_WorkoutItems_WorkoutItemWorkoutBlockWorkoutId_W~",
                        columns: x => new { x.WorkoutItemWorkoutBlockWorkoutId, x.WorkoutItemWorkoutBlockId, x.WorkoutItemId },
                        principalTable: "WorkoutItems",
                        principalColumns: new[] { "WorkoutBlockWorkoutId", "WorkoutBlockId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutSetTemplates",
                columns: table => new
                {
                    WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutItemTemplateWorkoutBlockTemplateId = table.Column<int>(type: "integer", nullable: false),
                    WorkoutItemTemplateId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSetTemplates", x => new { x.WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId, x.WorkoutItemTemplateWorkoutBlockTemplateId, x.WorkoutItemTemplateId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutSetTemplates_WorkoutItemTemplates_WorkoutItemTemplat~",
                        columns: x => new { x.WorkoutItemTemplateWorkoutBlockTemplateWorkoutTemplateId, x.WorkoutItemTemplateWorkoutBlockTemplateId, x.WorkoutItemTemplateId },
                        principalTable: "WorkoutItemTemplates",
                        principalColumns: new[] { "WorkoutBlockTemplateWorkoutTemplateId", "WorkoutBlockTemplateId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutSets");

            migrationBuilder.DropTable(
                name: "WorkoutSetTemplates");

            migrationBuilder.AddColumn<int>(
                name: "Reps",
                table: "WorkoutItemTemplates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "WorkoutItemTemplates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Reps",
                table: "WorkoutItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "WorkoutItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "WorkoutItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
