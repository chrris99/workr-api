using FastEndpoints;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.ExerciseSlice.CreateExercise;

public sealed class CreateExerciseMapper : Mapper<CreateExerciseRequest, ExerciseResponse, Exercise>
{
    public override Exercise ToEntity(CreateExerciseRequest r) => new()
    {
        Name = r.Name,
        CreatedBy = r.UserId,
        TargetMuscleGroup = r.TargetMuscleGroup,
        Type = r.Type ?? ExerciseType.Repeated,
        Description = r.Description,
        ForceType = r.ForceType,
        Instructions = r.Instructions,
        SecondaryMuscleGroups = r.SecondaryMuscleGroups
    };

    public override ExerciseResponse FromEntity(Exercise e) => new(
        e.Id.ToString(),
        e.Name,
        e.TargetMuscleGroup,
        e.Type,
        e.Description,
        e.ForceType,
        e.Instructions,
        e.SecondaryMuscleGroups);
}