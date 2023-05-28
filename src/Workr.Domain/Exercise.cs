namespace Workr.Domain;

public sealed class Exercise
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string TargetMuscleGroup { get; set; }
    public string ForceType { get; set; }
    public string? CreatedBy { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Instructions { get; set; }
    public List<string>? TargetMuscleGroups { get; set; }
}