using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;

namespace Workr.Web.Features.Exercise.UpdateExercise;

public sealed class UpdateExerciseEndpoint : Endpoint<UpdateExerciseRequest, ExerciseResponse, UpdateExerciseMapper>
{
    private readonly IExerciseRepository _repo;

    public UpdateExerciseEndpoint(IExerciseRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Put("/api/exercise/{id}");
        Claims("id");
    }

    public override async Task HandleAsync(UpdateExerciseRequest req, CancellationToken ct)
    {
        var exercise = Map.ToEntity(req);
        
        var result = await _repo.UpdateExercise(exercise);
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);

        ThrowIfAnyErrors();

        await SendOkAsync();
    }
}