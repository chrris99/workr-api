using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Domain.Errors;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutPlanSlice.GetWorkoutPlanById;

public sealed class GetWorkoutPlanByIdEndpoint
    : Endpoint<GetWorkoutPlanByIdRequest, WorkoutPlanResponse, WorkoutPlanResponseMapper>
{
    private readonly IWorkoutPlanRepository _repo;

    public GetWorkoutPlanByIdEndpoint(IWorkoutPlanRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Get("api/plan/{id}");
        Claims("id");
        PreProcessors(new RequestLogger<GetWorkoutPlanByIdRequest>());
    }

    public override async Task HandleAsync(GetWorkoutPlanByIdRequest req, CancellationToken ct)
    {
        var result = await _repo.GetWorkoutPlanById(req.WorkoutPlanId);
        
        if (result.IsFailure)
        {
            if (result.Error.Code == DomainErrors.WorkoutPlan.NotFoundById.Code)
                await SendNotFoundAsync();
            
            AddError(result.Error.Message, result.Error.Code);
        }
        
        ThrowIfAnyErrors();

        await SendAsync(Map.FromEntity(result.Value));
    }
}