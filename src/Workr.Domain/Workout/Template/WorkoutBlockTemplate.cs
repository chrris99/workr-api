namespace Workr.Domain.Workout.Template;

public sealed class WorkoutBlockTemplate
{
    public int Order { get; set; }
    public List<WorkoutItemTemplate> ItemTemplates { get; set; }
}