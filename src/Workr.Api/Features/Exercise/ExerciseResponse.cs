namespace Workr.Web.Features.Exercise;

public record ExerciseResponse(
    string Id,
    string Name,
    string TargetMuscleGroup,
    string? Description,
    string? ForceType,
    List<string>? Instructions,
    List<string>? SecondaryMuscleGroups);