﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExerciseType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Exercises");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Exercises",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
