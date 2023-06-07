using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutTemplateSlice.UpdateWorkoutTemplate;

public sealed class UpdateWorkoutTemplateEndpoint
    : Endpoint<UpdateWorkoutTemplateRequest, WorkoutTemplateResponse, UpdateWorkoutTemplateMapper>
{
    private readonly IWorkoutTemplateRepository _repo;

    public UpdateWorkoutTemplateEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Put("api/template/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<UpdateWorkoutTemplateRequest>());
    }

    public override async Task HandleAsync(UpdateWorkoutTemplateRequest req, CancellationToken ct)
    {
        var response = await _repo.UpdateWorkoutTemplate(Map.ToEntity(req));

        if (response.IsFailure)
            AddError(response.Error.Message, response.Error.Code);
        
        ThrowIfAnyErrors();

        await SendOkAsync();
    }
}