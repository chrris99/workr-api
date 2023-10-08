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

                    b.ToTable("Exercises");
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

                    b.ToTable("WorkoutPlans");
                });

            modelBuilder.Entity("Workr.Domain.Workout.Template.WorkoutTemplate", b =>
                {
                    b.OwnsMany("Workr.Domain.Workout.Template.WorkoutBlockTemplate", "BlockTemplates", b1 =>
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

                            b1.OwnsMany("Workr.Domain.Workout.Template.WorkoutItemTemplate", "ItemTemplates", b2 =>
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

                                    b2.OwnsMany("Workr.Domain.Workout.Template.WorkoutSetTemplate", "Sets", b3 =>
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

                    b.OwnsMany("Workr.Domain.Workout.WorkoutBlock", "Blocks", b1 =>
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

                            b1.OwnsMany("Workr.Domain.Workout.WorkoutItem", "Items", b2 =>
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

                                    b2.OwnsMany("Workr.Domain.Workout.WorkoutSet", "Sets", b3 =>
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
