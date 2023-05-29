using Microsoft.EntityFrameworkCore;
using Workr.Domain;
using Workr.Domain.Exercise;
using Workr.Domain.Workout;
using Workr.Domain.Workout.Template;

namespace Workr.Infrastructure.Persistence;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<WorkoutTemplate> WorkoutTemplates { get; set; }
    public DbSet<WorkoutPlan> WorkoutPlans { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

        base.OnModelCreating(modelBuilder);
    }
}