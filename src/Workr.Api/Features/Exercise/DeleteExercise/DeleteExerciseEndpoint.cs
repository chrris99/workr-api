using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;

namespace Workr.Web.Features.Exercise.DeleteExercise;

public sealed class DeleteExerciseEndpoint : EndpointWithoutRequest
{
    private readonly IExerciseRepository _repo;

    public DeleteExerciseEndpoint(IExerciseRepository repo) => _repo = repo;

    public override void Configure()
    {
        Delete("api/exercise/{id}");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var exerciseId = Route<Guid>("id");
        
        var result = await _repo.RemoveExercise(exerciseId);

        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);

        ThrowIfAnyErrors();

        await SendNoContentAsync(ct);
    }
}