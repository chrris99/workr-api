namespace Workr.Domain.Workout;

public sealed class WorkoutItem
{
    public Exercise.Exercise Exercise { get; set; }
    
    public int Sets { get; set; }
    public int  Reps { get; set; }
    public int Order { get; set; }
    public string Status { get; set; } = "not started";
    public string? Comment { get; set; }
    public int CurrentSet { get; set; }
}