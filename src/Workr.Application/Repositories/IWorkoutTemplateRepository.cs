using Workr.Core;
using Workr.Domain.Workout.Template;

namespace Workr.Application.Repositories;

public interface IWorkoutTemplateRepository
{
    public Task<Result<WorkoutTemplate>> CreateWorkoutTemplate(WorkoutTemplate workoutTemplate);
    public Task<Result<WorkoutTemplate>> GetWorkoutTemplateById(Guid workoutTemplateId);
    public Task<Result<List<WorkoutTemplate>>> GetWorkoutTemplates(string userId);
    public Task<Result> UpdateWorkoutTemplate(WorkoutTemplate workoutTemplate);
    public Task<Result> DeleteWorkoutTemplate(Guid workoutTemplateId, string userId);
}