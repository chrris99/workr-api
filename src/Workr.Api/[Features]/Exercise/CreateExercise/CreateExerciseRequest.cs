namespace Workr.Web._Features_.Exercise.CreateExercise;

public record CreateExerciseRequest(
    string Name,
    string? Description,
    List<string>? Instructions,
    List<string>? TargetMuscleGroups);