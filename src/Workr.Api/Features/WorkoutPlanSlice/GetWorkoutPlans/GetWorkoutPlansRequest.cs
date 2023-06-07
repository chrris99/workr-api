using FastEndpoints;

namespace Workr.Web.Features.WorkoutPlanSlice.GetWorkoutPlans;

public sealed class GetWorkoutPlansRequest
{
    [FromClaim("id")]
    public string UserId { get; set; }
}