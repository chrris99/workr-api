namespace Workr.Domain.Workout;

public sealed class WorkoutBlock
{
    public int Order { get; set; }
    public string Status { get; set; } = "not started";
    
    public List<WorkoutItem> Items { get; set; }
}