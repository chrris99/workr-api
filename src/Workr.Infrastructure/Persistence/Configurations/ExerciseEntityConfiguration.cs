using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain.Accessory;
using Workr.Domain.Exercise;

namespace Workr.Infrastructure.Persistence.Configurations;

public class ExerciseEntityConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasData(
            SystemExercise.BarbellBenchPress,
            SystemExercise.StandingBarbellCurl,
            SystemExercise.DumbbellBicepCurl,
            SystemExercise.DumbbellGobletSquat,
            SystemExercise.PushUp);


        builder
            .HasMany(e => e.Equipment)
            .WithMany(e => e.Exercises)
            .UsingEntity("EquipmentExercise",
                l => l.HasOne(typeof(Equipment)).WithMany().HasForeignKey("EquipmentId")
                    .HasPrincipalKey(nameof(Equipment.Id)),
                r => r.HasOne(typeof(Exercise)).WithMany().HasForeignKey("ExerciseId")
                    .HasPrincipalKey(nameof(Exercise.Id)),
                join =>
                {
                    join.HasKey("ExerciseId", "EquipmentId");
                    join.HasData(
                        new
                        {
                            ExerciseId = SystemExercise.BarbellBenchPressId, EquipmentId = EquipmentType.BarbellId
                        },
                        new
                        {
                            ExerciseId = SystemExercise.StandingBarbellCurlId, EquipmentId = EquipmentType.BarbellId
                        },
                        new
                        {
                            ExerciseId = SystemExercise.DumbbellGobletSquatId, EquipmentId = EquipmentType.DumbbellId
                        },
                        new
                        {
                            ExerciseId = SystemExercise.DumbbellBicepCurlId, EquipmentId = EquipmentType.DumbbellId
                        });
                });
    }
}