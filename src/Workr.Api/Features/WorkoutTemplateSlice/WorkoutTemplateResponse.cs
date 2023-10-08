using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutTemplateSlice;

public sealed class WorkoutTemplateResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<WorkoutBlockTemplateResponse> BlockTemplates { get; set; }
}

public sealed class WorkoutBlockTemplateResponse
{
    public int Order { get; set; }
    public List<WorkoutItemTemplateResponse> ItemTemplates { get; set; }
}

public sealed class WorkoutItemTemplateResponse
{
    public ExerciseResponse Exercise { get; set; }
    
    public List<WorkoutSetTemplateResponse> Sets { get; set; }
    public int Order { get; set; }
    public string? Comment { get; set; }
}

public sealed class WorkoutSetTemplateResponse
{
    public int Reps { get; set; }
    public int Weight { get; set; }
}