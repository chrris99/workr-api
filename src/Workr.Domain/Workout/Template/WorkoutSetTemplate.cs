namespace Workr.Domain.Workout.Template;

public sealed class WorkoutSetTemplate
{
    public int  Reps { get; set; }
    public int Weight { get; set; } // TODO should be ValueObject that includes unit
}