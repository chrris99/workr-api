using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutTemplateSlice.GetWorkoutTemplateById;

public class GetWorkoutTemplateByIdEndpoint 
    : EndpointWithoutRequest<WorkoutTemplateResponse>
{
    private readonly IWorkoutTemplateRepository _repo;

    public GetWorkoutTemplateByIdEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("/api/template/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<EmptyRequest>());
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        return base.HandleAsync(ct);
    }
}