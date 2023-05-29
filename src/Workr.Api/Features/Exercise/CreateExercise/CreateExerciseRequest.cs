using FastEndpoints;

namespace Workr.Web.Features.Exercise.CreateExercise;

public sealed class CreateExerciseRequest
{
    public string Name { get; set; }
    public string TargetMuscleGroup { get; set; }
    public string? Description { get; set; }
    public string? ForceType { get; set; }
    public string? Type { get; set; }
    public List<string>? Instructions { get; set; }
    public List<string>? SecondaryMuscleGroups { get; set; }

    [FromClaim("id")]
    public string UserId { get; set; }
}