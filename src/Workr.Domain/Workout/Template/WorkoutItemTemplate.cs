namespace Workr.Domain.Workout.Template;

public sealed class WorkoutItemTemplate
{
    public Exercise.Exercise Exercise { get; set; }
    
    public int Sets { get; set; }
    public int  Reps { get; set; }
    public int Order { get; set; }
    public string? Comment { get; set; }
}