using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.GetWorkoutTemplates;

public sealed class GetWorkoutTemplatesRequest
{
    [FromClaim("id")]
    public string UserId { get; set; }
}