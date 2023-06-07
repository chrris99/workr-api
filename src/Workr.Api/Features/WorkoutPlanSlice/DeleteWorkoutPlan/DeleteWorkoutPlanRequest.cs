using FastEndpoints;

namespace Workr.Web.Features.WorkoutPlanSlice.DeleteWorkoutPlan;

public sealed class DeleteWorkoutPlanRequest
{
    [BindFrom("id")]
    public Guid WorkoutPlanId { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}