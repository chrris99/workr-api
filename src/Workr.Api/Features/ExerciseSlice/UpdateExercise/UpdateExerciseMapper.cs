using FastEndpoints;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.ExerciseSlice.UpdateExercise;

public sealed class UpdateExerciseMapper : Mapper<UpdateExerciseRequest, ExerciseResponse, Exercise>
{
    public override Exercise ToEntity(UpdateExerciseRequest r)
    {
        return new()
        {
            Id = r.Id,
            Name = r.Name,
            CreatedBy = r.UserId,
            TargetMuscleGroup = r.TargetMuscleGroup,
            Description = r.Description,
            ForceType = r.ForceType,
            ImageUrl = r.ImageUrl,
            Instructions = r.Instructions,
            SecondaryMuscleGroups = r.SecondaryMuscleGroups
        };
    }

    public override ExerciseResponse FromEntity(Exercise e)
    {
        return new(
            e.Id.ToString(),
            e.Name,
            e.TargetMuscleGroup,
            e.Description,
            e.ForceType,
            e.ImageUrl,
            e.Instructions,
            e.SecondaryMuscleGroups);
    }
}