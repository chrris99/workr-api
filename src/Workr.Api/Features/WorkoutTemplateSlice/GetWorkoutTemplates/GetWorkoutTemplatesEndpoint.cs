using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;

namespace Workr.Web.Features.WorkoutTemplateSlice.GetWorkoutTemplates;

public sealed class GetWorkoutTemplatesEndpoint
    : Endpoint<GetWorkoutTemplatesRequest, List<WorkoutTemplateResponse>, WorkoutTemplateResponseMapper>
{
    private readonly IWorkoutTemplateRepository _repo;

    public GetWorkoutTemplatesEndpoint(IWorkoutTemplateRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("api/template");
    }

    public override async Task HandleAsync(GetWorkoutTemplatesRequest req, CancellationToken ct)
    {
        var result = await _repo.GetWorkoutTemplates(req.UserId);

        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var response = result.Value
            .Select(template => Map.FromEntity(template))
            .ToList();

        await SendAsync(response);
    }
}