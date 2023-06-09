namespace Workr.Web.Features.ExerciseSlice;

public record ExerciseResponse(
    string Id,
    string Name,
    string TargetMuscleGroup,
    string Type,
    string? Description,
    string? ForceType,
    List<string>? Instructions,
    List<string>? SecondaryMuscleGroups);