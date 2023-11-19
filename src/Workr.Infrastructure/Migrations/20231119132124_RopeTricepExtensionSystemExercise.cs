using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Workr.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RopeTricepExtensionSystemExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b03f63a-f9f7-48bc-873c-cf6d0eb410ee"), "Bike" },
                    { new Guid("4f2ab131-f799-411d-9fa7-4bdad130ab6a"), "Treadmill" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[] { new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"), "Barbell", true });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6752f225-adc7-4063-94d9-cae858b541e9"), "JumpRope" },
                    { new Guid("839e201b-b294-4d4c-ac09-11cee7548476"), "Bar" }
                });

            migrationBuilder.InsertData(
                table: "Accessories",
                columns: new[] { "Id", "Name", "Weight" },
                values: new object[,]
                {
                    { new Guid("a603498a-9785-4e3d-a147-e4335b5f8c58"), "Cable", true },
                    { new Guid("efac03a4-e8d6-4201-8ebd-1f98792721c2"), "Kettlebell", true },
                    { new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"), "Dumbbell", true }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "CreatedBy", "Description", "ForceType", "ImageUrl", "Instructions", "Name", "SecondaryMuscleGroups", "TargetMuscleGroup" },
                values: new object[,]
                {
                    { new Guid("913666a8-f6c4-494d-87d2-5b6f637aadca"), "system", "The barbell bench press is a classic exercise, known as one of the \"big three\" lifts. The bench press is a compound exercise that targets many of the muscles in your upper body.", "push", "bench-press-2.png", new List<string> { "Lie flat on a bench and set your hands just outside of shoulder width.", "Set your shoulder blades by pinching them together and driving them into the bench.", "Take a deep breath, lift off and maintain tightness through your upper back.", "Inhale and allow the bar to descend slowly by unlocking the elbows.", "Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest.", "Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows." }, "Barbell Bench Press", new List<string> { "triceps", "shoulders" }, "chest" },
                    { new Guid("93e45a6a-93e0-4c98-a10a-14276ac1ee92"), "system", "TODO", "push", "bench-press-2.png", new List<string>(), "Dumbbell Bicep Curl", null, "biceps" },
                    { new Guid("986ea2f4-2cae-42b7-8225-5ebf4b5b440f"), "system", "", "push", "cable-machine-tricep-extension-1.png", null, "Rope Tricep Extension", null, "triceps" },
                    { new Guid("bba819e7-d8ec-4501-8df4-056608c026e5"), "system", "The push up is an exercise used to target the muscles of the chest. It also indirectly works the muscles of the shoulder, triceps, and core.", "push", "push-up.png", new List<string>(), "Push Up", new List<string> { "shoulders", "triceps", "abs" }, "chest" },
                    { new Guid("f706990d-7b75-444e-addf-66e0c6439a6f"), "system", "The standing barbell curl is the cornerstone of many bicep building routines.", "pull", "barbell-bicep-curl-1.png", new List<string> { "Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up).", "Stand straight up, feet together, back straight, and with your arms fully extended. The bar should not be touching your body.", "Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up.", "Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position." }, "Standing Barbell Curl", null, "biceps" },
                    { new Guid("fc1e07eb-37a6-4d40-a7e8-d0b24046518e"), "system", "The dumbbell goblet squat is a variation of the squat and is used to build the muscles of the legs. In particular, the dumbbell goblet squat places a lot of emphasis on the quads.", "push", "dumbbell-squat-1.png", new List<string> { "Select a dumbbell and position it at chest height with one hand under each edge of the dumbbell.", "Take a deep breath and descend by simultaneously pushing the hips back and bending the knees.", "Once your thighs reach parallel with the floor, begin to reverse the movement.", "Keep your abs braced and drive your feet through the floor, to get back to the starting position." }, "Dumbbell Goblet Squat", null, "quads" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentExercise",
                columns: new[] { "EquipmentId", "ExerciseId" },
                values: new object[,]
                {
                    { new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"), new Guid("913666a8-f6c4-494d-87d2-5b6f637aadca") },
                    { new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"), new Guid("93e45a6a-93e0-4c98-a10a-14276ac1ee92") },
                    { new Guid("a603498a-9785-4e3d-a147-e4335b5f8c58"), new Guid("986ea2f4-2cae-42b7-8225-5ebf4b5b440f") },
                    { new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"), new Guid("f706990d-7b75-444e-addf-66e0c6439a6f") },
                    { new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"), new Guid("fc1e07eb-37a6-4d40-a7e8-d0b24046518e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("3b03f63a-f9f7-48bc-873c-cf6d0eb410ee"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("4f2ab131-f799-411d-9fa7-4bdad130ab6a"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("6752f225-adc7-4063-94d9-cae858b541e9"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("839e201b-b294-4d4c-ac09-11cee7548476"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("efac03a4-e8d6-4201-8ebd-1f98792721c2"));

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"), new Guid("913666a8-f6c4-494d-87d2-5b6f637aadca") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"), new Guid("93e45a6a-93e0-4c98-a10a-14276ac1ee92") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("a603498a-9785-4e3d-a147-e4335b5f8c58"), new Guid("986ea2f4-2cae-42b7-8225-5ebf4b5b440f") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"), new Guid("f706990d-7b75-444e-addf-66e0c6439a6f") });

            migrationBuilder.DeleteData(
                table: "EquipmentExercise",
                keyColumns: new[] { "EquipmentId", "ExerciseId" },
                keyValues: new object[] { new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"), new Guid("fc1e07eb-37a6-4d40-a7e8-d0b24046518e") });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bba819e7-d8ec-4501-8df4-056608c026e5"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("529fe1ec-2c7b-4dc3-8ffd-f1157797efb4"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("a603498a-9785-4e3d-a147-e4335b5f8c58"));

            migrationBuilder.DeleteData(
                table: "Accessories",
                keyColumn: "Id",
                keyValue: new Guid("f1a3f291-8c41-4856-ac5a-a340c96502be"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("913666a8-f6c4-494d-87d2-5b6f637aadca"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("93e45a6a-93e0-4c98-a10a-14276ac1ee92"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("986ea2f4-2cae-42b7-8225-5ebf4b5b440f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f706990d-7b75-444e-addf-66e0c6439a6f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc1e07eb-37a6-4d40-a7e8-d0b24046518e"));

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
        }
    }
}
