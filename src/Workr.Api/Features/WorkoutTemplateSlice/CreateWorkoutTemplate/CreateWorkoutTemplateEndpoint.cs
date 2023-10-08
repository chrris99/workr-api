using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Features.WorkoutTemplateSlice.GetWorkoutTemplateById;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutTemplateSlice.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateEndpoint
    : Endpoint<CreateWorkoutTemplateRequest, WorkoutTemplateResponse, CreateWorkoutTemplateMapper>
{
    private readonly IWorkoutTemplateRepository _repo;

    public CreateWorkoutTemplateEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Post("api/template");
        Claims("id");
        Summary(new CreateWorkoutTemplateSummary());
        PreProcessors(new RequestLogger<CreateWorkoutTemplateRequest>());
    }

    public override async Task HandleAsync(CreateWorkoutTemplateRequest req, CancellationToken ct)
    {
        Logger.LogInformation("hello ${req}", req);
        var workoutTemplate = Map.ToEntity(req);

        var result = await _repo.CreateWorkoutTemplate(workoutTemplate);
        
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var response = Map.FromEntity(result.Value);
        await SendCreatedAtAsync<GetWorkoutTemplateByIdEndpoint>(new { id = response.Id }, response);
    }
}