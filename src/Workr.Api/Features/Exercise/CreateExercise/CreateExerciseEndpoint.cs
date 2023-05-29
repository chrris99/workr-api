using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;
using Workr.Web.Features.Exercise.GetExerciseById;

namespace Workr.Web.Features.Exercise.CreateExercise;

public sealed class CreateExerciseEndpoint : Endpoint<CreateExerciseRequest, ExerciseResponse, CreateExerciseMapper>
{
    private readonly IExerciseRepository _repository;

    public CreateExerciseEndpoint(IExerciseRepository repository) => _repository = repository;
    
    public override void Configure()
    {
        Post("/api/exercise");
        Claims("id");
    }

    public override async Task HandleAsync(CreateExerciseRequest req, CancellationToken ct)
    {
        var exercise = Map.ToEntity(req);
        
        var result = await _repository.CreateExercise(exercise);
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);

        ThrowIfAnyErrors();

        var response = Map.FromEntity(result.Value);
        await SendCreatedAtAsync<GetExerciseByIdEndpoint>(new { id = response.Id }, response);
    }
}