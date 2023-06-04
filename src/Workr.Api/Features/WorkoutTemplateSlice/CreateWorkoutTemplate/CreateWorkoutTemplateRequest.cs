using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<CreateWorkoutBlockTemplateRequest> BlockTemplateRequests { get; set; }
    
    [FromClaim]
    public string UserId { get; set; }
}

public sealed class CreateWorkoutBlockTemplateRequest
{
    public int Order { get; set; }
    public List<CreateWorkoutItemTemplateRequest> ItemTemplateRequests { get; set; }
}

public sealed class CreateWorkoutItemTemplateRequest
{
    public Guid ExerciseId { get; set; }
    
    public int Sets { get; set; }
    public int  Reps { get; set; }
    public int Order { get; set; }
    public string? Comment { get; set; }
}