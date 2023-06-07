using FastEndpoints;
using Workr.Domain.Workout;
using Workr.Web.Features.ExerciseSlice;

namespace Workr.Web.Features.WorkoutSlice.CreateWorkout;

public sealed class CreateWorkoutMapper : Mapper<CreateWorkoutRequest, WorkoutResponse, Workout>
{
    public override Workout ToEntity(CreateWorkoutRequest r) => new()
    {
        Name = r.Name,
        CreatedBy = r.UserId,
        Description = r.Description,
        Start = r.Start,
        Comment = r.Comment,
        Blocks = r.WorkoutBlocks.Select(b =>
        {
            return new WorkoutBlock
            {
                Order = b.Order,
                Items = b.WorkoutItems.Select(i => new WorkoutItem
                {
                    Sets = i.Sets,
                    Reps = i.Reps,
                    Weight = i.Weight,
                    Order = i.Order,
                    Comment = i.Comment
                }).ToList()
            };
        }).ToList()
    };

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
                Sets = i.Sets,
                Reps = i.Reps,
                Weight = i.Weight,
                Order = i.Order,
                Comment = i.Comment,
                Exercise = new ExerciseResponse(
                    i.Exercise.Id.ToString(),
                    i.Exercise.Name,
                    i.Exercise.TargetMuscleGroup,
                    i.Exercise.Type,
                    i.Exercise.Description,
                    i.Exercise.ForceType,
                    i.Exercise.Instructions,
                    i.Exercise.SecondaryMuscleGroups)
            }).ToList()
        }).ToList()
    };
}