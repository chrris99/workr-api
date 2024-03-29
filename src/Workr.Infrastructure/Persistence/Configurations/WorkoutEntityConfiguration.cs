using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain;
using Workr.Domain.Workout;

namespace Workr.Infrastructure.Persistence.Configurations;

public sealed class WorkoutEntityConfiguration : IEntityTypeConfiguration<Workout>
{
    public void Configure(EntityTypeBuilder<Workout> builder)
    {
        builder.ToTable("Workouts");
        builder.HasKey(w => w.Id);
        
        builder.Property(w => w.Name)
            .HasMaxLength(100);

        builder.Property(w => w.Description)
            .HasMaxLength(100);

        builder.OwnsMany(w => w.Blocks, blockBuilder =>
        {
            blockBuilder.ToTable("WorkoutBlocks");
            blockBuilder.WithOwner().HasForeignKey("WorkoutId");
            
            blockBuilder.OwnsMany(wb => wb.Items, itemBuilder =>
            {
                itemBuilder.ToTable("WorkoutItems");
                itemBuilder.WithOwner().HasForeignKey("WorkoutId", "WorkoutBlockId");
                
                itemBuilder.OwnsMany(ib => ib.Sets, setBuilder =>
                {
                    setBuilder.ToTable("WorkoutSets");
                    setBuilder.WithOwner().HasForeignKey("WorkoutId", "WorkoutBlockId", "WorkoutItemId");
                });
            });
        });
    }
}