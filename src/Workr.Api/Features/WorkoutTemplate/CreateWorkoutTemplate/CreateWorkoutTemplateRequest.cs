using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplate.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateRequest
{
    [FromClaim]
    public string UserId { get; set; }
}