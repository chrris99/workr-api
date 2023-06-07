using FastEndpoints;
using Workr.Application.Repositories;
using Workr.Web.Features.WorkoutPlanSlice.GetWorkoutPlanById;
using Workr.Web.Processors;

namespace Workr.Web.Features.WorkoutPlanSlice.CreateWorkoutPlan;

public sealed class CreateWorkoutPlanEndpoint
    : Endpoint<CreateWorkoutPlanRequest, WorkoutPlanResponse, CreateWorkoutPlanMapper>
{
    private readonly IWorkoutPlanRepository _repo;

    public CreateWorkoutPlanEndpoint(IWorkoutPlanRepository repo) => _repo = repo;
    
    public override void Configure()
    {
        Post("api/plan");
        Claims("id");
        PreProcessors(new RequestLogger<CreateWorkoutPlanRequest>());
    }

    public override async Task HandleAsync(CreateWorkoutPlanRequest req, CancellationToken ct)
    {
        var result = await _repo.CreateWorkoutPlan(Map.ToEntity(req));
        
        if (result.IsFailure)
            AddError(result.Error.Message, result.Error.Code);
        
        ThrowIfAnyErrors();

        var response = Map.FromEntity(result.Value);
        await SendCreatedAtAsync<GetWorkoutPlanByIdEndpoint>(new { id = response.Id }, response);
    }
}