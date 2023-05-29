using FastEndpoints;
using Workr.Application;
using Workr.Application.Repositories;
using Workr.Domain.Errors;

namespace Workr.Web.Features.Exercise.GetExerciseById;

public sealed class GetExerciseByIdEndpoint : EndpointWithoutRequest<ExerciseResponse, ExerciseResponseMapper>
{
    private readonly IExerciseRepository _repo;

    public GetExerciseByIdEndpoint(IExerciseRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("/api/exercise/{id}");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var exerciseId = Route<Guid>("id");

        var result = await _repo.GetExerciseById(exerciseId);

        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.Exercise.NotFoundById.Code)
                await SendNotFoundAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendAsync(Map.FromEntity(result.Value));
    }
}