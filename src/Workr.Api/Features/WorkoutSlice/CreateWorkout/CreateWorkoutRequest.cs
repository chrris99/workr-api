using FastEndpoints;

namespace Workr.Web.Features.WorkoutSlice.CreateWorkout;

public sealed class CreateWorkoutRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? Start { get; set; }
    public string? Comment { get; set; }
    
    public List<CreateWorkoutBlockRequest> WorkoutBlocks { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}

public sealed class CreateWorkoutBlockRequest
{
    public int Order { get; set; }
    public List<CreateWorkoutItemRequest> WorkoutItems { get; set; }
}

public sealed class CreateWorkoutItemRequest
{
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int Weight { get; set; }
    public int Order { get; set; }
    public string? Comment { get; set; }
    public Guid ExerciseId { get; set; }
}