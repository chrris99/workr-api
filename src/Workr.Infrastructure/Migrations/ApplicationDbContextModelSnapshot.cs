﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Workr.Infrastructure.Persistence;

#nullable disable

namespace Workr.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EquipmentExercise", b =>
                {
                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EquipmentId")
                        .HasColumnType("uuid");

                    b.HasKey("ExerciseId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentExercise", (string)null);

                    b.HasData(
                        new
                        {
                            ExerciseId = new Guid("60a41714-318d-40ba-98a2-dbe5e2ae8bb5"),
                            EquipmentId = new Guid("4c9e1eb0-6ab5-44a6-b8dd-e1a9ff4c41bd")
                        },
                        new
                        {
                            ExerciseId = new Guid("54c07e15-5f68-49b6-9c95-4986c52676f4"),
                            EquipmentId = new Guid("4c9e1eb0-6ab5-44a6-b8dd-e1a9ff4c41bd")
                        },
                        new
                        {
                            ExerciseId = new Guid("c2a66847-8319-436c-859f-33b7895c4e4f"),
                            EquipmentId = new Guid("c1d36df2-0674-4f21-ba67-9f7b4c0d971b")
                        },
                        new
                        {
                            ExerciseId = new Guid("04d32bd5-4de6-40bc-89c4-67ee7bcdfaf2"),
                            EquipmentId = new Guid("c1d36df2-0674-4f21-ba67-9f7b4c0d971b")
                        },
                        new
                        {
                            ExerciseId = new Guid("2627b21a-880f-42fc-8a28-da81e3a4e5ee"),
                            EquipmentId = new Guid("b634ea02-7da8-4939-a617-3dea58119d96")
                        });
                });

            modelBuilder.Entity("Workr.Domain.Accessory.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Weight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Accessories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2af529f3-728b-4f68-ad13-7854775f08d7"),
                            Name = "Kettlebell",
                            Weight = true
                        },
                        new
                        {
                            Id = new Guid("c1d36df2-0674-4f21-ba67-9f7b4c0d971b"),
                            Name = "Dumbbell",
                            Weight = true
                        },
                        new
                        {
                            Id = new Guid("4c9e1eb0-6ab5-44a6-b8dd-e1a9ff4c41bd"),
                            Name = "Barbell",
                            Weight = true
                        },
                        new
                        {
                            Id = new Guid("933463e2-bc2d-40c0-bcb8-95c0116e4472"),
                            Name = "Bar",
                            Weight = false
                        },
                        new
                        {
                            Id = new Guid("1e5e3259-d9dc-4101-b042-231ea31c4744"),
                            Name = "Treadmill",
                            Weight = false
                        },
                        new
                        {
                            Id = new Guid("b12affcf-4498-4423-b505-7bef0129a6f5"),
                            Name = "Bike",
                            Weight = false
                        },
                        new
                        {
                            Id = new Guid("422e35ec-7c4f-4304-abef-8e44f73080e9"),
                            Name = "JumpRope",
                            Weight = false
                        },
                        new
                        {
                            Id = new Guid("b634ea02-7da8-4939-a617-3dea58119d96"),
                            Name = "Cable",
                            Weight = true
                        });
                });

            modelBuilder.Entity("Workr.Domain.Exercise.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ForceType")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<List<string>>("Instructions")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("SecondaryMuscleGroups")
                        .HasColumnType("text[]");

                    b.Property<string>("TargetMuscleGroup")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exercises", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("60a41714-318d-40ba-98a2-dbe5e2ae8bb5"),
                            CreatedBy = "system",
                            Description = "The barbell bench press is a classic exercise, known as one of the \"big three\" lifts. The bench press is a compound exercise that targets many of the muscles in your upper body.",
                            ForceType = "push",
                            ImageUrl = "bench-press-2.png",
                            Instructions = new List<string> { "Lie flat on a bench and set your hands just outside of shoulder width.", "Set your shoulder blades by pinching them together and driving them into the bench.", "Take a deep breath, lift off and maintain tightness through your upper back.", "Inhale and allow the bar to descend slowly by unlocking the elbows.", "Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest.", "Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows." },
                            Name = "Barbell Bench Press",
                            SecondaryMuscleGroups = new List<string> { "triceps", "shoulders" },
                            TargetMuscleGroup = "chest"
                        },
                        new
                        {
                            Id = new Guid("54c07e15-5f68-49b6-9c95-4986c52676f4"),
                            CreatedBy = "system",
                            Description = "The standing barbell curl is the cornerstone of many bicep building routines.",
                            ForceType = "pull",
                            ImageUrl = "barbell-bicep-curl-1.png",
                            Instructions = new List<string> { "Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up).", "Stand straight up, feet together, back straight, and with your arms fully extended. The bar should not be touching your body.", "Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up.", "Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position." },
                            Name = "Standing Barbell Curl",
                            TargetMuscleGroup = "biceps"
                        },
                        new
                        {
                            Id = new Guid("04d32bd5-4de6-40bc-89c4-67ee7bcdfaf2"),
                            CreatedBy = "system",
                            ForceType = "push",
                            ImageUrl = "dumbbell-bicep-curl-1.png",
                            Instructions = new List<string>(),
                            Name = "Dumbbell Bicep Curl",
                            TargetMuscleGroup = "biceps"
                        },
                        new
                        {
                            Id = new Guid("c2a66847-8319-436c-859f-33b7895c4e4f"),
                            CreatedBy = "system",
                            Description = "The dumbbell goblet squat is a variation of the squat and is used to build the muscles of the legs. In particular, the dumbbell goblet squat places a lot of emphasis on the quads.",
                            ForceType = "push",
                            ImageUrl = "dumbbell-squat-1.png",
                            Instructions = new List<string> { "Select a dumbbell and position it at chest height with one hand under each edge of the dumbbell.", "Take a deep breath and descend by simultaneously pushing the hips back and bending the knees.", "Once your thighs reach parallel with the floor, begin to reverse the movement.", "Keep your abs braced and drive your feet through the floor, to get back to the starting position." },
                            Name = "Dumbbell Goblet Squat",
                            TargetMuscleGroup = "quads"
                        },
                        new
                        {
                            Id = new Guid("c1cb1145-5e02-4dd1-8983-564ec95a22f4"),
                            CreatedBy = "system",
                            Description = "The push up is an exercise used to target the muscles of the chest. It also indirectly works the muscles of the shoulder, triceps, and core.",
                            ForceType = "push",
                            ImageUrl = "push-up.png",
                            Instructions = new List<string>(),
                            Name = "Push Up",
                            SecondaryMuscleGroups = new List<string> { "shoulders", "triceps", "abs" },
                            TargetMuscleGroup = "chest"
                        },
                        new
                        {
                            Id = new Guid("2627b21a-880f-42fc-8a28-da81e3a4e5ee"),
                            CreatedBy = "system",
                            Description = "Test description",
                            ForceType = "push",
                            ImageUrl = "cable-machine-tricep-extension-1.png",
                            Name = "Rope Tricep Extension",
                            TargetMuscleGroup = "triceps"
                        });
                });

            modelBuilder.Entity("Workr.Domain.Workout.Template.WorkoutTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("WorkoutTemplates", (string)null);
                });

            modelBuilder.Entity("Workr.Domain.Workout.Workout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("WorkoutPlanId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutPlanId");

                    b.ToTable("Workouts", (string)null);
                });

            modelBuilder.Entity("Workr.Domain.Workout.WorkoutPlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AssignedTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CurrentDay")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentWeek")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfWeeks")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("WorkoutPlans", (string)null);
                });

            modelBuilder.Entity("EquipmentExercise", b =>
                {
                    b.HasOne("Workr.Domain.Accessory.Equipment", null)
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workr.Domain.Exercise.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Workr.Domain.Workout.Template.WorkoutTemplate", b =>
                {
                    b.OwnsMany("Workr.Domain.Workout.Template.WorkoutTemplate.BlockTemplates#Workr.Domain.Workout.Template.WorkoutBlockTemplate", "BlockTemplates", b1 =>
                        {
                            b1.Property<Guid>("WorkoutTemplateId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<int>("Order")
                                .HasColumnType("integer");

                            b1.HasKey("WorkoutTemplateId", "Id");

                            b1.ToTable("WorkoutBlockTemplates", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("WorkoutTemplateId");

                            b1.OwnsMany("Workr.Domain.Workout.Template.WorkoutTemplate.BlockTemplates#Workr.Domain.Workout.Template.WorkoutBlockTemplate.ItemTemplates#Workr.Domain.Workout.Template.WorkoutItemTemplate", "ItemTemplates", b2 =>
                                {
                                    b2.Property<Guid>("WorkoutTemplateId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("WorkoutBlockTemplateId")
                                        .HasColumnType("integer");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b2.Property<int>("Id"));

                                    b2.Property<string>("Comment")
                                        .HasColumnType("text");

                                    b2.Property<Guid>("ExerciseId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Order")
                                        .HasColumnType("integer");

                                    b2.HasKey("WorkoutTemplateId", "WorkoutBlockTemplateId", "Id");

                                    b2.HasIndex("ExerciseId");

                                    b2.ToTable("WorkoutItemTemplates", (string)null);

                                    b2.HasOne("Workr.Domain.Exercise.Exercise", "Exercise")
                                        .WithMany()
                                        .HasForeignKey("ExerciseId")
                                        .OnDelete(DeleteBehavior.Cascade)
                                        .IsRequired();

                                    b2.WithOwner()
                                        .HasForeignKey("WorkoutTemplateId", "WorkoutBlockTemplateId");

                                    b2.OwnsMany("Workr.Domain.Workout.Template.WorkoutTemplate.BlockTemplates#Workr.Domain.Workout.Template.WorkoutBlockTemplate.ItemTemplates#Workr.Domain.Workout.Template.WorkoutItemTemplate.Sets#Workr.Domain.Workout.Template.WorkoutSetTemplate", "Sets", b3 =>
                                        {
                                            b3.Property<Guid>("WorkoutTemplateId")
                                                .HasColumnType("uuid");

                                            b3.Property<int>("WorkoutBlockTemplateId")
                                                .HasColumnType("integer");

                                            b3.Property<int>("WorkoutItemTemplateId")
                                                .HasColumnType("integer");

                                            b3.Property<int>("Id")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("integer");

                                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b3.Property<int>("Id"));

                                            b3.Property<int>("Reps")
                                                .HasColumnType("integer");

                                            b3.Property<int>("Weight")
                                                .HasColumnType("integer");

                                            b3.HasKey("WorkoutTemplateId", "WorkoutBlockTemplateId", "WorkoutItemTemplateId", "Id");

                                            b3.ToTable("WorkoutSetTemplates", (string)null);

                                            b3.WithOwner()
                                                .HasForeignKey("WorkoutTemplateId", "WorkoutBlockTemplateId", "WorkoutItemTemplateId");
                                        });

                                    b2.Navigation("Exercise");

                                    b2.Navigation("Sets");
                                });

                            b1.Navigation("ItemTemplates");
                        });

                    b.Navigation("BlockTemplates");
                });

            modelBuilder.Entity("Workr.Domain.Workout.Workout", b =>
                {
                    b.HasOne("Workr.Domain.Workout.WorkoutPlan", null)
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutPlanId");

                    b.OwnsMany("Workr.Domain.Workout.Workout.Blocks#Workr.Domain.Workout.WorkoutBlock", "Blocks", b1 =>
                        {
                            b1.Property<Guid>("WorkoutId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<int>("Order")
                                .HasColumnType("integer");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("WorkoutId", "Id");

                            b1.ToTable("WorkoutBlocks", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("WorkoutId");

                            b1.OwnsMany("Workr.Domain.Workout.Workout.Blocks#Workr.Domain.Workout.WorkoutBlock.Items#Workr.Domain.Workout.WorkoutItem", "Items", b2 =>
                                {
                                    b2.Property<Guid>("WorkoutId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("WorkoutBlockId")
                                        .HasColumnType("integer");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("integer");

                                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b2.Property<int>("Id"));

                                    b2.Property<string>("Comment")
                                        .HasColumnType("text");

                                    b2.Property<int>("CurrentSet")
                                        .HasColumnType("integer");

                                    b2.Property<Guid>("ExerciseId")
                                        .HasColumnType("uuid");

                                    b2.Property<int>("Order")
                                        .HasColumnType("integer");

                                    b2.Property<string>("Status")
                                        .IsRequired()
                                        .HasColumnType("text");

                                    b2.HasKey("WorkoutId", "WorkoutBlockId", "Id");

                                    b2.HasIndex("ExerciseId");

                                    b2.ToTable("WorkoutItems", (string)null);

                                    b2.HasOne("Workr.Domain.Exercise.Exercise", "Exercise")
                                        .WithMany()
                                        .HasForeignKey("ExerciseId")
                                        .OnDelete(DeleteBehavior.Cascade)
                                        .IsRequired();

                                    b2.WithOwner()
                                        .HasForeignKey("WorkoutId", "WorkoutBlockId");

                                    b2.OwnsMany("Workr.Domain.Workout.Workout.Blocks#Workr.Domain.Workout.WorkoutBlock.Items#Workr.Domain.Workout.WorkoutItem.Sets#Workr.Domain.Workout.WorkoutSet", "Sets", b3 =>
                                        {
                                            b3.Property<Guid>("WorkoutId")
                                                .HasColumnType("uuid");

                                            b3.Property<int>("WorkoutBlockId")
                                                .HasColumnType("integer");

                                            b3.Property<int>("WorkoutItemId")
                                                .HasColumnType("integer");

                                            b3.Property<int>("Id")
                                                .ValueGeneratedOnAdd()
                                                .HasColumnType("integer");

                                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b3.Property<int>("Id"));

                                            b3.Property<int>("Reps")
                                                .HasColumnType("integer");

                                            b3.Property<int>("Weight")
                                                .HasColumnType("integer");

                                            b3.HasKey("WorkoutId", "WorkoutBlockId", "WorkoutItemId", "Id");

                                            b3.ToTable("WorkoutSets", (string)null);

                                            b3.WithOwner()
                                                .HasForeignKey("WorkoutId", "WorkoutBlockId", "WorkoutItemId");
                                        });

                                    b2.Navigation("Exercise");

                                    b2.Navigation("Sets");
                                });

                            b1.Navigation("Items");
                        });

                    b.Navigation("Blocks");
                });

            modelBuilder.Entity("Workr.Domain.Workout.WorkoutPlan", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
