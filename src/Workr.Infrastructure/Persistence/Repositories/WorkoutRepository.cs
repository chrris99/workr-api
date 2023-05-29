using Workr.Application;
using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain.Workout.Template;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class WorkoutRepository : IWorkoutRepository
{
    public Task<Result<WorkoutTemplate>> CreateWorkoutTemplate(WorkoutTemplate exercise)
    {
        throw new NotImplementedException();
    }
}