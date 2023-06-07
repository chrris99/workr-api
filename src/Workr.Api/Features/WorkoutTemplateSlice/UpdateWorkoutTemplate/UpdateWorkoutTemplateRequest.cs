using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.UpdateWorkoutTemplate;

public sealed class UpdateWorkoutTemplateRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<UpdateWorkoutBlockTemplateRequest> BlockTemplateRequests { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}

public sealed class UpdateWorkoutBlockTemplateRequest
{
    public int Order { get; set; }
    public List<UpdateWorkoutItemTemplateRequest> ItemTemplateRequests { get; set; }
}

public sealed class UpdateWorkoutItemTemplateRequest
{
    public Guid ExerciseId { get; set; }
    
    public int Sets { get; set; }
    public int  Reps { get; set; }
    public int Order { get; set; }
    public string? Comment { get; set; }
}