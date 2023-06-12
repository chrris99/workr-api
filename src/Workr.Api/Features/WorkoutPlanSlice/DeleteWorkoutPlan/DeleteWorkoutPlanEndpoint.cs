using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutPlanSlice.DeleteWorkoutPlan;

public sealed class DeleteWorkoutPlanEndpoint : Endpoint<DeleteWorkoutPlanRequest>
{
    private readonly IWorkoutPlanRepository _repo;

    public DeleteWorkoutPlanEndpoint(IWorkoutPlanRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Delete("api/plan/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<DeleteWorkoutPlanRequest>());
    }

    public override Task HandleAsync(DeleteWorkoutPlanRequest req, CancellationToken ct)
    {
        return base.HandleAsync(req, ct);
    }
}