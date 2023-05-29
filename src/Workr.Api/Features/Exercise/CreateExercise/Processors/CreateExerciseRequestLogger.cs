using FastEndpoints;
using FluentValidation.Results;

namespace Workr.Web.Features.Exercise.CreateExercise.Processors;

public sealed class CreateExerciseRequestLogger : IPreProcessor<CreateExerciseRequest>
{
    public Task PreProcessAsync(CreateExerciseRequest req, HttpContext ctx, List<ValidationFailure> failures,
        CancellationToken ct)
    {
        var logger = ctx.Resolve<ILogger<CreateExerciseRequest>>();
        
        logger.LogInformation("Create exercise request");

        return Task.CompletedTask;
    }
}