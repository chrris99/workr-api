using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutSlice.DeleteWorkout;

public sealed class DeleteWorkoutEndpoint : Endpoint<DeleteWorkoutRequest>
{
    private readonly IWorkoutRepository _repo;

    public DeleteWorkoutEndpoint(IWorkoutRepository repo) => _repo = repo;

    public override void Configure()
    {
        Delete("api/workout/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<DeleteWorkoutRequest>());
    }

    public override async Task HandleAsync(DeleteWorkoutRequest req, CancellationToken ct)
    {
        var result = await _repo.DeleteWorkout(req.WorkoutId, req.UserId);
        
        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.Workout.Forbidden.Code)
                await SendForbiddenAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendNoContentAsync(ct);
    }
}