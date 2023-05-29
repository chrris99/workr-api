using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.Exercise.GetExercises;

public sealed class GetExercisesEndpoint : EndpointWithoutRequest<List<ExerciseResponse>, ExerciseResponseMapper>
{
    private readonly IExerciseRepository _repo;

    public GetExercisesEndpoint(IExerciseRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("/api/exercise");
        PreProcessors(new RequestLogger<EmptyRequest>());
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var result = await _repo.GetExercises();
        
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var exerciseResponses = result.Value.
            Select(e => Map.FromEntity(e))
            .ToList();

        await SendAsync(exerciseResponses);
    }
}