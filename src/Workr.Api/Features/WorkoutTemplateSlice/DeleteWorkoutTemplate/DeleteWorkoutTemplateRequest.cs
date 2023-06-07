using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.DeleteWorkoutTemplate;

public sealed class DeleteWorkoutTemplateRequest
{
    [BindFrom("id")]
    public Guid WorkoutTemplateId { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}