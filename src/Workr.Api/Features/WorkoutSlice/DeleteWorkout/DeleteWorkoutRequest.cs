using FastEndpoints;

namespace Workr.Web.Features.WorkoutSlice.DeleteWorkout;

public class DeleteWorkoutRequest
{
    [BindFrom("id")]
    public Guid WorkoutId { get; set; }

    [FromClaim("id")]
    public string UserId { get; set; }
}