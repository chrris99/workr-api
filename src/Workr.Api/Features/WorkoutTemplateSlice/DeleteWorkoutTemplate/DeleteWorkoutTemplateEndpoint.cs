using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutTemplateSlice.DeleteWorkoutTemplate;

public sealed class DeleteWorkoutTemplateEndpoint : Endpoint<DeleteWorkoutTemplateRequest>
{
    private readonly IWorkoutTemplateRepository _repo;

    public DeleteWorkoutTemplateEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Delete("/api/template/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<DeleteWorkoutTemplateRequest>());
    }

    public override async Task HandleAsync(DeleteWorkoutTemplateRequest req, CancellationToken ct)
    {
        var result = await _repo.DeleteWorkoutTemplate(req.WorkoutTemplateId, req.UserId);

        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.WorkoutTemplate.Forbidden.Code)
                await SendForbiddenAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendNoContentAsync(ct);
    }
}