using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutTemplateSlice.GetWorkoutTemplateById;

public class GetWorkoutTemplateByIdEndpoint 
    : EndpointWithoutRequest<WorkoutTemplateResponse, WorkoutTemplateResponseMapper>
{
    private readonly IWorkoutTemplateRepository _repo;

    public GetWorkoutTemplateByIdEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("/api/template/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<EmptyRequest>());
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var workoutTemplateId = Route<Guid>("id");

        var result = await _repo.GetWorkoutTemplateById(workoutTemplateId);
        
        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.WorkoutTemplate.NotFoundById.Code)
                await SendNotFoundAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendAsync(Map.FromEntity(result.Value));
    }
}