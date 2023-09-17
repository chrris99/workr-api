using FastEndpoints;
using Workr.Domain.Workout;

namespace Workr.Web.Features.WorkoutPlanSlice.CreateWorkoutPlan;

public sealed class CreateWorkoutPlanMapper : Mapper<CreateWorkoutPlanRequest, WorkoutPlanResponse, WorkoutPlan>
{
    public override WorkoutPlan ToEntity(CreateWorkoutPlanRequest r) => new()
    {

    };

    public override WorkoutPlanResponse FromEntity(WorkoutPlan e)
    {
        return base.FromEntity(e);
    }
}