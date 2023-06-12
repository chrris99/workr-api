using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TargetMuscleGroup = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Instructions = table.Column<List<string>>(type: "text[]", nullable: true),
                    ForceType = table.Column<string>(type: "text", nullable: true),
                    SecondaryMuscleGroups = table.Column<List<string>>(type: "text[]", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    AssignedTo = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    NumberOfWeeks = table.Column<int>(type: "integer", nullable: false),
                    CurrentWeek = table.Column<int>(type: "integer", nullable: false),
                    NumberOfDays = table.Column<int>(type: "integer", nullable: false),
                    CurrentDay = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlans", x => x.Id);
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
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    WorkoutPlanId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_WorkoutPlans_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "WorkoutPlans",
                        principalColumn: "Id");
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
                    Weight = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutItems_ExerciseId",
                table: "WorkoutItems",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutItemTemplates_ExerciseId",
                table: "WorkoutItemTemplates",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutPlanId",
                table: "Workouts",
                column: "WorkoutPlanId");
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
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "WorkoutBlockTemplates");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "WorkoutTemplates");

            migrationBuilder.DropTable(
                name: "WorkoutPlans");
        }
    }
}
