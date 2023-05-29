using Workr.Core;
using Workr.Domain.Exercise;

namespace Workr.Application.Repositories;

public interface IExerciseRepository
{
    public Task<Result<Exercise>> CreateExercise(Exercise exercise);
    public Task<Result<Exercise>> GetExerciseById(Guid exerciseId);
    public Task<Result<List<Exercise>>> GetExercises();
    public Task<Result> UpdateExercise(Exercise exercise);
    public Task<Result> RemoveExercise(Guid exerciseId);
}