using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Processors;

namespace Workr.Web.Features.ExerciseSlice.UpdateExercise;

public sealed class UpdateExerciseEndpoint : Endpoint<UpdateExerciseRequest, ExerciseResponse, UpdateExerciseMapper>
{
    private readonly IExerciseRepository _repo;

    public UpdateExerciseEndpoint(IExerciseRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Put("/api/exercise/{id}");
        Claims("id"); 
        PreProcessors(new RequestLogger<UpdateExerciseRequest>());
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