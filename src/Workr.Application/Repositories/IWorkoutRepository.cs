using Workr.Core;
using Workr.Domain.Workout.Template;

namespace Workr.Application.Repositories;

public interface IWorkoutRepository
{
    public Task<Result<WorkoutTemplate>> CreateWorkoutTemplate(WorkoutTemplate exercise);
}