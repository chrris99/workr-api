using Workr.Domain.Accessory;

namespace Workr.Domain.Exercise;

public sealed class Exercise
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string TargetMuscleGroup { get; set; }
    public string CreatedBy { get; set; } = "system";
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Instructions { get; set; }
    public string? ForceType { get; set; }
    public List<string>? SecondaryMuscleGroups { get; set; }
    public List<Equipment> Equipment { get; set; } = new();
}