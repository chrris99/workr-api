using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Workr.Domain;
using Workr.Domain.Workout.Template;

namespace Workr.Infrastructure.Persistence.Configurations;

public sealed class WorkoutTemplateEntityConfiguration : IEntityTypeConfiguration<WorkoutTemplate>
{
    public void Configure(EntityTypeBuilder<WorkoutTemplate> builder)
    {
        builder.ToTable("WorkoutTemplates");
        builder.HasKey(w => w.Id);
        
        builder.Property(w => w.Name)
            .HasMaxLength(100);

        builder.Property(w => w.Description)
            .HasMaxLength(100);

        builder.OwnsMany(w => w.BlockTemplates, blockBuilder =>
        {
            blockBuilder.ToTable("WorkoutBlockTemplates");
            
            blockBuilder.OwnsMany(wb => wb.ItemTemplates, itemBuilder =>
            {
                itemBuilder.ToTable("WorkoutItemTemplates");
            });
        });
    }
}