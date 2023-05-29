namespace Workr.Domain.Workout;

public sealed class WorkoutPlan
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    
    public string CreatedBy { get; set; }
    public string AssignedTo { get; set; }
    
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public string Status { get; set; } = "not started";
    
    public int NumberOfWeeks { get; set; }
    public int CurrentWeek { get; set; }
    
    public int NumberOfDays { get; set; }
    public int CurrentDay { get; set; }

    public List<Domain.Workout.Workout> Workouts { get; set; }
}