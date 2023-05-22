using FastEndpoints;

namespace Workr.Web._Features_.Exercise.CreateExercise;

public sealed class CreateExerciseEndpoint : Endpoint<CreateExerciseRequest, ExerciseResponse, ExerciseMapper>
{
    public override void Configure()
    {
        Post("/api/exercise");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateExerciseRequest req, CancellationToken ct)
    {
        var exercise = Map.ToEntity(req);
        await SendAsync(Map.FromEntity(exercise));
    }
}