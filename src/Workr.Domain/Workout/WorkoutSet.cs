namespace Workr.Domain.Workout;

public sealed class WorkoutSet
{
    public int  Reps { get; set; }
    public int Weight { get; set; } // TODO should be ValueObject that includes unit
}