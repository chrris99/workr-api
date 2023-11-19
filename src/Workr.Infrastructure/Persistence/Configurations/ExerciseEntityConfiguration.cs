using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain.Accessory;
using Workr.Domain.Exercise;
using Workr.Infrastructure.Persistence.Seed;

namespace Workr.Infrastructure.Persistence.Configurations;

public class ExerciseEntityConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasData(
            SystemExerciseData.BarbellBenchPress,
            SystemExerciseData.StandingBarbellCurl,
            SystemExerciseData.DumbbellBicepCurl,
            SystemExerciseData.DumbbellGobletSquat,
            SystemExerciseData.PushUp,
            SystemExerciseData.RopeTricepExtension);


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
                            ExerciseId = SystemExerciseData.BarbellBenchPressId, EquipmentId = EquipmentData.BarbellId
                        },
                        new
                        {
                            ExerciseId = SystemExerciseData.StandingBarbellCurlId, EquipmentId = EquipmentData.BarbellId
                        },
                        new
                        {
                            ExerciseId = SystemExerciseData.DumbbellGobletSquatId,
                            EquipmentId = EquipmentData.DumbbellId
                        },
                        new
                        {
                            ExerciseId = SystemExerciseData.DumbbellBicepCurlId, EquipmentId = EquipmentData.DumbbellId
                        },
                        new
                        {
                            ExerciseId = SystemExerciseData.RopeTricepExtensionId, EquipmentId = EquipmentData.CableId
                        });
                });
    }
}