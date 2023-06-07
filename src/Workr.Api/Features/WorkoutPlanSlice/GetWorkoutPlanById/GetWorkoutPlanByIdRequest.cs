using FastEndpoints;

namespace Workr.Web.Features.WorkoutPlanSlice.GetWorkoutPlanById;

public sealed class GetWorkoutPlanByIdRequest
{
    [BindFrom("id")]
    public Guid WorkoutPlanId { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}