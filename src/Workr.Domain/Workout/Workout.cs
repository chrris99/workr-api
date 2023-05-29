namespace Workr.Domain.Workout;

public sealed class Workout
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public string Status { get; set; } = "not started";
    public string? Description { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public string? Comment { get; set; }
    
    public List<WorkoutBlock> Blocks { get; set; }
}