using Workr.Core;
using Workr.Domain.Workout;

namespace Workr.Application.Repositories;

public interface IWorkoutRepository
{
    public Task<Result<Workout>> CreateWorkout(Workout workout);
    public Task<Result<Workout>> GetWorkoutById(Guid workoutId);
    public Task<Result<List<Workout>>> GetWorkouts(string userId);
    public Task<Result> UpdateWorkout(Workout workout);
    public Task<Result> DeleteWorkout(Guid workoutId, string userId);
}