using FastEndpoints;
using Workr.Domain.Exercise;
using Workr.Domain.Workout.Template;
using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutTemplateSlice.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateMapper
    : Mapper<CreateWorkoutTemplateRequest, WorkoutTemplateResponse, WorkoutTemplate>
{
    public override WorkoutTemplate ToEntity(CreateWorkoutTemplateRequest r) => new()
    {
        Name = r.Name,
        Description = r.Description,
        CreatedBy = r.UserId,
        BlockTemplates = r.BlockTemplateRequests.Select(btr =>
        {
            return new WorkoutBlockTemplate
            {
                Order = btr.Order,
                ItemTemplates = btr.ItemTemplateRequests.Select(itr => new WorkoutItemTemplate
                {
                    Exercise = new Exercise
                    {
                        Id = itr.ExerciseId
                    },
                    Order = itr.Order,
                    Reps = itr.Reps,
                    Sets = itr.Sets,
                    Comment = itr.Comment
                }).ToList()
            };
        }).ToList()
    };

    public override WorkoutTemplateResponse FromEntity(WorkoutTemplate e) => new()
    {
        Id = e.Id,
        Name = e.Name,
        Description = e.Description,
        BlockTemplates = e.BlockTemplates.Select(blockTemplate =>
        {
            return new WorkoutBlockTemplateResponse
            {
                Order = blockTemplate.Order,
                ItemTemplates = blockTemplate.ItemTemplates.Select(itemTemplate =>
                {
                    var exercise = itemTemplate.Exercise;

                    return new WorkoutItemTemplateResponse
                    {
                        Exercise = new ExerciseResponse(
                            exercise.Id.ToString(),
                            exercise.Name,
                            exercise.TargetMuscleGroup,
                            exercise.Description,
                            exercise.ForceType,
                            exercise.Instructions,
                            exercise.SecondaryMuscleGroups),
                        Order = itemTemplate.Order,
                        Sets = itemTemplate.Sets,
                        Reps = itemTemplate.Reps,
                        Comment = itemTemplate.Comment
                    };
                }).ToList()
            };
        }).ToList()
    };
}