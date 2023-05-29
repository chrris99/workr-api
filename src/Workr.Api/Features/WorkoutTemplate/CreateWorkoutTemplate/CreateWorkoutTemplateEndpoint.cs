using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;

namespace Workr.Web.Features.WorkoutTemplate.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateEndpoint : Endpoint<CreateWorkoutTemplateRequest>
{
    private readonly IWorkoutTemplateRepository _repo;

    public CreateWorkoutTemplateEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Post("api/template");
        Claims("id");
    }

    public override Task HandleAsync(CreateWorkoutTemplateRequest req, CancellationToken ct)
    {
        
        return base.HandleAsync(req, ct);
    }
}