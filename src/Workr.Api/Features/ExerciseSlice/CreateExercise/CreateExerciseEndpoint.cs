using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Features.ExerciseSlice.GetExerciseById;
using Workr.Web.Processors;

namespace Workr.Web.Features.ExerciseSlice.CreateExercise;

public sealed class CreateExerciseEndpoint : Endpoint<CreateExerciseRequest, ExerciseResponse, CreateExerciseMapper>
{
    private readonly IExerciseRepository _repository;

    public CreateExerciseEndpoint(IExerciseRepository repository) => _repository = repository;
    
    public override void Configure()
    {
        Post("/api/exercise");
        Claims("id");
        Summary(new CreateExerciseSummary());
        PreProcessors(new RequestLogger<CreateExerciseRequest>());
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