using FastEndpoints;

namespace Workr.Web.Features.WorkoutSlice.GetWorkouts;

public class GetWorkoutsRequest
{
    [FromClaim("id")]
    public string UserId { get; set; }
}