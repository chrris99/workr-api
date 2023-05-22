using Workr.Domain;

namespace Workr.Application;

public interface IExerciseRepository
{
    public void CreateExercise(Exercise exercise);
    public Exercise GetExerciseById(string exerciseId);
    public List<Exercise> GetExercises();
    public void UpdateExercise(string exerciseId, Exercise exercise);
    public void RemoveExercise(string exerciseId);
}