using FastEndpoints;
using Workr.Domain.Workout;

namespace Workr.Web.Features.WorkoutPlanSlice;

public sealed class WorkoutPlanResponseMapper : ResponseMapper<WorkoutPlanResponse, WorkoutPlan>
{
    public override WorkoutPlanResponse FromEntity(WorkoutPlan e) => new()
    {

    };
}