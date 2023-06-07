using Workr.Core;
using Workr.Domain.Workout;

namespace Workr.Application.Repositories;

public interface IWorkoutPlanRepository
{
    public Task<Result<WorkoutPlan>> CreateWorkoutPlan(WorkoutPlan workoutPlan);
    public Task<Result<WorkoutPlan>> GetWorkoutPlanById(Guid workoutPlanId);
    public Task<Result<List<WorkoutPlan>>> GetWorkoutPlans(string userId);
    public Task<Result> UpdateWorkoutPlan(WorkoutPlan workoutPlan);
    public Task<Result> DeleteWorkoutPlan(Guid workoutPlanId, string userId);
}