using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain.Accessory;

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
            EquipmentType.Kettlebell,
            EquipmentType.Dumbbell,
            EquipmentType.Barbell,
            EquipmentType.Bar,
            EquipmentType.Treadmill,
            EquipmentType.Bike,
            EquipmentType.JumpRope);
    }
}