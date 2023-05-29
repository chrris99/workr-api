using Microsoft.Extensions.DependencyInjection;
using Workr.Application.Repositories;
using Workr.Infrastructure.Persistence.Repositories;

namespace Workr.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<IWorkoutRepository, WorkoutRepository>();
        services.AddScoped<IWorkoutTemplateRepository, WorkoutTemplateRepository>();

        return services;
    }
}