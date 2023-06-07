using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Features.WorkoutSlice.GetWorkoutById;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutSlice.CreateWorkout;

public sealed class CreateWorkoutEndpoint : Endpoint<CreateWorkoutRequest, WorkoutResponse, CreateWorkoutMapper>
{
    private readonly IWorkoutRepository _repo;

    public CreateWorkoutEndpoint(IWorkoutRepository repo) => _repo = repo;
    
    public override void Configure()
    {  
        Post("api/workout");
        Claims("id");
        PreProcessors(new RequestLogger<CreateWorkoutRequest>());
    }

    public override async Task HandleAsync(CreateWorkoutRequest req, CancellationToken ct)
    {
        var result = await _repo.CreateWorkout(Map.ToEntity(req));

        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var response = Map.FromEntity(result.Value);
        await SendCreatedAtAsync<GetWorkoutByIdEndpoint>(new { id = response.Id }, response);
    }
}