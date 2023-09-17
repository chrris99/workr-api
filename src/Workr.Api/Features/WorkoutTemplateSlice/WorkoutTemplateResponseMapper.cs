using FastEndpoints;
using Workr.Domain.Workout.Template;
using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutTemplateSlice;

public class WorkoutTemplateResponseMapper : ResponseMapper<WorkoutTemplateResponse, WorkoutTemplate>
{
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