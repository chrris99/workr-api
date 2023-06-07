using FastEndpoints;

namespace Workr.Web.Features.WorkoutSlice.GetWorkoutById;

public class GetWorkoutByIdRequest
{
    [BindFrom("id")]
    public Guid WorkoutId { get; set; }

    [FromClaim("id")]
    public string UserId { get; set; }
}