using FastEndpoints;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.ExerciseSlice.CreateExercise;

public sealed class CreateExerciseMapper : Mapper<CreateExerciseRequest, ExerciseResponse, Exercise>
{
    public override Exercise ToEntity(CreateExerciseRequest r)
    {
        return new()
        {
            Name = r.Name,
            CreatedBy = r.UserId,
            TargetMuscleGroup = r.TargetMuscleGroup,
            Description = r.Description,
            ForceType = r.ForceType,
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