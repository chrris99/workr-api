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
    public List<UpdateWorkoutItemTemplateRequest> ItemTemplateRequests { get; set; }
}

public sealed class UpdateWorkoutItemTemplateRequest
{
    public Guid ExerciseId { get; set; }
    public List<UpdateWorkoutSetTemplateRequest> SetTemplateRequests { get; set; }
    public string? Comment { get; set; }
}

public sealed class UpdateWorkoutSetTemplateRequest
{
    public int Reps { get; set; }
    public int Weight { get; set; }
}