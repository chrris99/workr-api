using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Features.WorkoutSlice;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutPlanSlice.GetWorkoutPlans;

public sealed class GetWorkoutPlansEndpoint
    : Endpoint<GetWorkoutPlansRequest, List<WorkoutPlanResponse>, WorkoutResponseMapper>
{
    private readonly IWorkoutPlanRepository _repo;

    public GetWorkoutPlansEndpoint(IWorkoutPlanRepository repo) => _repo = repo;

    public override void Configure()
    {
        Get("api/plan");
        Claims("id");
        PreProcessors(new RequestLogger<GetWorkoutPlansRequest>());
    }

    public override Task HandleAsync(GetWorkoutPlansRequest req, CancellationToken ct)
    {
        return base.HandleAsync(req, ct);
    }
}