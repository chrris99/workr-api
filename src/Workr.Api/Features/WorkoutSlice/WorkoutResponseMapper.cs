using FastEndpoints;
using Workr.Domain.Workout;
using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutSlice;

public sealed class WorkoutResponseMapper : ResponseMapper<WorkoutResponse, Workout>
{
    public override WorkoutResponse FromEntity(Workout e) => new()
    {
        Id = e.Id,
        Name = e.Name,
        Start = e.Start,
        End = e.End,
        Status = e.Status,
        Description = e.Description,
        Comment = e.Comment,
        WorkoutBlocks = e.Blocks.Select(b => new WorkoutBlockResponse
        {
            Order = b.Order,
            Status = b.Status,
            WorkoutItems = b.Items.Select(i => new WorkoutItemResponse
            {
                Sets = i.Sets.Select(set => new WorkoutSetResponse
                {
                    Reps = set.Reps,
                    Weight = set.Weight
                }).ToList(),
                Order = i.Order,
                Comment = i.Comment,
                Exercise = new ExerciseResponse(
                    i.Exercise.Id.ToString(),
                    i.Exercise.Name,
                    i.Exercise.TargetMuscleGroup,
                    i.Exercise.Description,
                    i.Exercise.ForceType,
                    i.Exercise.Instructions,
                    i.Exercise.SecondaryMuscleGroups)
            }).ToList()
        }).ToList()
    };
}