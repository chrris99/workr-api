using Workr.Core;
using Workr.Domain.Workout.Template;

namespace Workr.Application.Repositories;

public interface IWorkoutTemplateRepository
{
    public Task<Result<WorkoutTemplate>> CreateWorkoutTemplate(WorkoutTemplate workoutTemplate);
    public Task<Result<WorkoutTemplate>> GetWorkoutTemplateById(Guid workoutTemplateId);
}