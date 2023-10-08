using System.Text.Json.Serialization;
using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateRequest
{
    public string Name { get; set; }
    public string? Description { get; set; }
    
    [JsonPropertyName("blocks")]
    public List<CreateWorkoutBlockTemplateRequest> BlockTemplateRequests { get; set; }
    
    [FromClaim("id")]
    public string UserId { get; set; }
}

public sealed class CreateWorkoutBlockTemplateRequest
{
    [JsonPropertyName("items")]
    public List<CreateWorkoutItemTemplateRequest> ItemTemplateRequests { get; set; }
}

public sealed class CreateWorkoutItemTemplateRequest
{
    public Guid ExerciseId { get; set; }
    
    [JsonPropertyName("sets")]
    public List<CreateWorkoutSetTemplateRequest> SetTemplateRequests { get; set; }
    public string? Comment { get; set; }
}

public sealed class CreateWorkoutSetTemplateRequest
{
    public int Reps { get; set; }
    public int Weight { get; set; }
}