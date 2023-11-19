using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain.Accessory;
using Workr.Infrastructure.Persistence.Seed;

namespace Workr.Infrastructure.Persistence.Configurations;

public sealed class AccessoryEntityConfiguration : IEntityTypeConfiguration<Equipment>
{
    public void Configure(EntityTypeBuilder<Equipment> builder)
    {
        builder.ToTable("Accessories");

        builder.Property(a => a.Weight)
            .HasDefaultValue(false);

        builder.HasIndex(a => a.Name);

        builder.HasData(
            EquipmentData.Kettlebell,
            EquipmentData.Dumbbell,
            EquipmentData.Barbell,
            EquipmentData.Bar,
            EquipmentData.Treadmill,
            EquipmentData.Bike,
            EquipmentData.JumpRope,
            EquipmentData.Cable);
    }
}