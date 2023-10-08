using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutSlice;

public sealed class WorkoutResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string? Description { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public string? Comment { get; set; }

    public List<WorkoutBlockResponse> WorkoutBlocks { get; set; }
}

public sealed class WorkoutBlockResponse
{
    public int Order { get; set; }
    public string Status { get; set; }

    public List<WorkoutItemResponse> WorkoutItems { get; set; }
}

public sealed class WorkoutItemResponse
{
    public List<WorkoutSetResponse> Sets { get; set; }
    public int? CurrentSet { get; set; }
    public int Order { get; set; }
    public string Status { get; set; }
    public string? Comment { get; set; }
    
    public ExerciseResponse Exercise { get; set; }
}

public sealed class WorkoutSetResponse
{
    public int Reps { get; set; }
    public int Weight { get; set; }
}