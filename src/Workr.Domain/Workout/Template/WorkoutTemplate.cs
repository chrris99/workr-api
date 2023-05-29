namespace Workr.Domain.Workout.Template;

public sealed class WorkoutTemplate
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public string? Description { get; set; }
    
    public List<WorkoutBlockTemplate> BlockTemplates { get; set; }
}