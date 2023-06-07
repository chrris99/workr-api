using Workr.Application.Repositories;
using Workr.Core;
using Workr.Domain.Workout;

namespace Workr.Infrastructure.Persistence.Repositories;

public sealed class WorkoutPlanRepository : IWorkoutPlanRepository
{
    public Task<Result<WorkoutPlan>> CreateWorkoutPlan(WorkoutPlan workoutPlan)
    {
        throw new NotImplementedException();
    }

    public Task<Result<WorkoutPlan>> GetWorkoutPlanById(Guid workoutPlanId)
    {
        throw new NotImplementedException();
    }

    public Task<Result<List<WorkoutPlan>>> GetWorkoutPlans(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateWorkoutPlan(WorkoutPlan workoutPlan)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteWorkoutPlan(Guid workoutPlanId, string userId)
    {
        throw new NotImplementedException();
    }
}