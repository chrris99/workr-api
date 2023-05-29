using FastEndpoints;

namespace Workr.Web.Features.Exercise.UpdateExercise;

public sealed class UpdateExerciseRequest
{
    [BindFrom("id")]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string TargetMuscleGroup { get; set; }
    public string? Description { get; set; }
    public string? ForceType { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Instructions { get; set; }
    public List<string>? SecondaryMuscleGroups { get; set; }

    [FromClaim("id")]
    public string UserId { get; set; }
}