using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutSlice.GetWorkoutById;

public sealed class GetWorkoutByIdEndpoint : Endpoint<GetWorkoutByIdRequest, WorkoutResponse, WorkoutResponseMapper>
{
    private readonly IWorkoutRepository _repo;
    public GetWorkoutByIdEndpoint(IWorkoutRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("api/workout/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<GetWorkoutByIdRequest>());
    }

    public override async Task HandleAsync(GetWorkoutByIdRequest req, CancellationToken ct)
    {
        var result = await _repo.GetWorkoutById(req.WorkoutId);
        
        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.Workout.NotFoundById.Code)
                await SendNotFoundAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendAsync(Map.FromEntity(result.Value));
    }
}