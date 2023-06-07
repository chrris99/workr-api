using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutSlice.GetWorkouts;

public sealed class GetWorkoutsEndpoint
    : Endpoint<GetWorkoutsRequest, List<WorkoutResponse>, WorkoutResponseMapper>
{
    private readonly IWorkoutRepository _repo;

    public GetWorkoutsEndpoint(IWorkoutRepository repo) => _repo = repo;

    public override void Configure()
    {
        Get("api/workout");
        Claims("id");
        PreProcessors(new RequestLogger<GetWorkoutsRequest>());
    }

    public override async Task HandleAsync(GetWorkoutsRequest req, CancellationToken ct)
    {
        var result = await _repo.GetWorkouts(req.UserId);
        
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var response = result.Value
            .Select(workout => Map.FromEntity(workout))
            .ToList();

        await SendAsync(response);
    }
}