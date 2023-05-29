using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutItem");

            migrationBuilder.DropTable(
                name: "WorkoutBlock");

            migrationBuilder.CreateTable(
                name: "WorkoutBlocks",
                columns: table => new
                {
                    WorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutBlocks", x => new { x.WorkoutId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutBlocks_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutItems",
                columns: table => new
                {
                    WorkoutBlockWorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutBlockId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Sets = table.Column<int>(type: "integer", nullable: false),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    CurrentSet = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutItems", x => new { x.WorkoutBlockWorkoutId, x.WorkoutBlockId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutItems_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutItems_WorkoutBlocks_WorkoutBlockWorkoutId_WorkoutBlo~",
                        columns: x => new { x.WorkoutBlockWorkoutId, x.WorkoutBlockId },
                        principalTable: "WorkoutBlocks",
                        principalColumns: new[] { "WorkoutId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutBlockTemplates",
                columns: table => new
                {
                    WorkoutTemplateId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutBlockTemplates", x => new { x.WorkoutTemplateId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutBlockTemplates_WorkoutTemplates_WorkoutTemplateId",
                        column: x => x.WorkoutTemplateId,
                        principalTable: "WorkoutTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutItemTemplates",
                columns: table => new
                {
                    WorkoutBlockTemplateWorkoutTemplateId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutBlockTemplateId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Sets = table.Column<int>(type: "integer", nullable: false),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutItemTemplates", x => new { x.WorkoutBlockTemplateWorkoutTemplateId, x.WorkoutBlockTemplateId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutItemTemplates_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutItemTemplates_WorkoutBlockTemplates_WorkoutBlockTemp~",
                        columns: x => new { x.WorkoutBlockTemplateWorkoutTemplateId, x.WorkoutBlockTemplateId },
                        principalTable: "WorkoutBlockTemplates",
                        principalColumns: new[] { "WorkoutTemplateId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutItems_ExerciseId",
                table: "WorkoutItems",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutItemTemplates_ExerciseId",
                table: "WorkoutItemTemplates",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutItems");

            migrationBuilder.DropTable(
                name: "WorkoutItemTemplates");

            migrationBuilder.DropTable(
                name: "WorkoutBlocks");

            migrationBuilder.DropTable(
                name: "WorkoutBlockTemplates");

            migrationBuilder.DropTable(
                name: "WorkoutTemplates");

            migrationBuilder.CreateTable(
                name: "WorkoutBlock",
                columns: table => new
                {
                    WorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutBlock", x => new { x.WorkoutId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutBlock_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutItem",
                columns: table => new
                {
                    WorkoutBlockWorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkoutBlockId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    CurrentSet = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Sets = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutItem", x => new { x.WorkoutBlockWorkoutId, x.WorkoutBlockId, x.Id });
                    table.ForeignKey(
                        name: "FK_WorkoutItem_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutItem_WorkoutBlock_WorkoutBlockWorkoutId_WorkoutBlock~",
                        columns: x => new { x.WorkoutBlockWorkoutId, x.WorkoutBlockId },
                        principalTable: "WorkoutBlock",
                        principalColumns: new[] { "WorkoutId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutItem_ExerciseId",
                table: "WorkoutItem",
                column: "ExerciseId");
        }
    }
}
