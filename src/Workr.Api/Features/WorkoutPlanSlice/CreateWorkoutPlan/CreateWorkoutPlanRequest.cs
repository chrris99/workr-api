using FastEndpoints;

namespace Workr.Web.Features.WorkoutPlanSlice.CreateWorkoutPlan;

public sealed class CreateWorkoutPlanRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }

    public int NumberOfWeeks { get; set; }
    public int NumberOfDays { get; set; }

    public List<Guid> WorkoutIds { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}