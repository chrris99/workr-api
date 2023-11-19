namespace Workr.Web.Features.ExerciseSlice;

public record ExerciseResponse(
    string Id,
    string Name,
    string TargetMuscleGroup,
    string? Description,
    string? ForceType,
    string? ImageUrl,
    List<string>? Instructions,
    List<string>? SecondaryMuscleGroups);