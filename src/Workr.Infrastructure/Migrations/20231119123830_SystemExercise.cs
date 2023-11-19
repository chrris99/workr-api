using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SystemExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentExercise_Exercises_ExercisesId",
                table: "EquipmentExercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentExercise",
                table: "EquipmentExercise");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentExercise_ExercisesId",
                table: "EquipmentExercise");

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

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "EquipmentExercise",
                newName: "ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentExercise",
                table: "EquipmentExercise",
                columns: new[] { "ExerciseId", "EquipmentId" });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5eb210b7-21a5-4a5e-9d24-79d6eaa8a8b7"), "Bike" },
                    { new Guid("622af5d7-51da-48ea-9c4e-a354891da77a"), "JumpRope" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"), "Barbell", true });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9966be65-ff45-4b9b-ad81-faf8fbb6715d"), "Treadmill" },
                    { new Guid("c26a2a03-7762-4492-88b8-cbd65355df11"), "Bar" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"), "Dumbbell", true },
                    { new Guid("e8e5564b-db12-4386-9b90-14ca34e63eeb"), "Kettlebell", true }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedBy", "Description", "ForceType", "ImageUrl", "Instructions", "Name", "SecondaryMuscleGroups", "TargetMuscleGroup" },
                values: new object[,]
                {
                    { new Guid("107431a3-ced2-457f-a824-fcdeda2dc6c7"), "system", "TODO", "push", "bench-press-2.png", new List<string>(), "Dumbbell Bicep Curl", null, "biceps" },
                    { new Guid("1346e2d8-48a4-4e94-b07f-d92f924a7a30"), "system", "The standing barbell curl is the cornerstone of many bicep building routines.", "pull", "barbell-bicep-curl-1.png", new List<string> { "Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up).", "Stand straight up, feet together, back straight, and with your arms fully extended. The bar should not be touching your body.", "Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up.", "Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position." }, "Standing Barbell Curl", null, "biceps" },
                    { new Guid("86afccdc-5512-424c-9e76-232ae32e8158"), "system", "The barbell bench press is a classic exercise, known as one of the \"big three\" lifts. The bench press is a compound exercise that targets many of the muscles in your upper body.", "push", "bench-press-2.png", new List<string> { "Lie flat on a bench and set your hands just outside of shoulder width.", "Set your shoulder blades by pinching them together and driving them into the bench.", "Take a deep breath, lift off and maintain tightness through your upper back.", "Inhale and allow the bar to descend slowly by unlocking the elbows.", "Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest.", "Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows." }, "Barbell Bench Press", new List<string> { "triceps", "shoulders" }, "chest" },
                    { new Guid("b22b3310-fd03-4bd0-8070-c7fa9fca2cfe"), "system", "The push up is an exercise used to target the muscles of the chest. It also indirectly works the muscles of the shoulder, triceps, and core.", "push", "push-up.png", new List<string>(), "Push Up", new List<string> { "shoulders", "triceps", "abs" }, "chest" },
                    { new Guid("d90493e8-5a65-4909-bbd8-819474958fea"), "system", "The dumbbell goblet squat is a variation of the squat and is used to build the muscles of the legs. In particular, the dumbbell goblet squat places a lot of emphasis on the quads.", "push", "dumbbell-squat-1.png", new List<string> { "Select a dumbbell and position it at chest height with one hand under each edge of the dumbbell.", "Take a deep breath and descend by simultaneously pushing the hips back and bending the knees.", "Once your thighs reach parallel with the floor, begin to reverse the movement.", "Keep your abs braced and drive your feet through the floor, to get back to the starting position." }, "Dumbbell Goblet Squat", null, "quads" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentExercise",
                columns: new[] { "EquipmentId", "ExerciseId" },
                values: new object[,]
                {
                    { new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"), new Guid("107431a3-ced2-457f-a824-fcdeda2dc6c7") },
                    { new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"), new Guid("1346e2d8-48a4-4e94-b07f-d92f924a7a30") },
                    { new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"), new Guid("86afccdc-5512-424c-9e76-232ae32e8158") },
                    { new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"), new Guid("d90493e8-5a65-4909-bbd8-819474958fea") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentExercise_EquipmentId",
                table: "EquipmentExercise",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentExercise_Exercises_ExerciseId",
                table: "EquipmentExercise",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentExercise_Exercises_ExerciseId",
                table: "EquipmentExercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EquipmentExercise",
                table: "EquipmentExercise");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentExercise_EquipmentId",
                table: "EquipmentExercise");

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("5eb210b7-21a5-4a5e-9d24-79d6eaa8a8b7"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("622af5d7-51da-48ea-9c4e-a354891da77a"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("9966be65-ff45-4b9b-ad81-faf8fbb6715d"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("c26a2a03-7762-4492-88b8-cbd65355df11"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("e8e5564b-db12-4386-9b90-14ca34e63eeb"));

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"), new Guid("107431a3-ced2-457f-a824-fcdeda2dc6c7") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"), new Guid("1346e2d8-48a4-4e94-b07f-d92f924a7a30") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"), new Guid("86afccdc-5512-424c-9e76-232ae32e8158") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"), new Guid("d90493e8-5a65-4909-bbd8-819474958fea") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b22b3310-fd03-4bd0-8070-c7fa9fca2cfe"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("82957022-100f-4e18-81fb-a5f58bff8be9"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("cdfc0723-b6ad-4fed-b50d-0c9973535930"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("107431a3-ced2-457f-a824-fcdeda2dc6c7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1346e2d8-48a4-4e94-b07f-d92f924a7a30"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("86afccdc-5512-424c-9e76-232ae32e8158"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d90493e8-5a65-4909-bbd8-819474958fea"));

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "EquipmentExercise",
                newName: "ExercisesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EquipmentExercise",
                table: "EquipmentExercise",
                columns: new[] { "EquipmentId", "ExercisesId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentExercise_Exercises_ExercisesId",
                table: "EquipmentExercise",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
