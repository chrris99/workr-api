using FastEndpoints;

namespace Workr.Web.Features.Exercise.CreateExercise;

public sealed class CreateExerciseMapper : Mapper<CreateExerciseRequest, ExerciseResponse, Domain.Exercise.Exercise>
{
    public override Domain.Exercise.Exercise ToEntity(CreateExerciseRequest r) => new()
    {
        Name = r.Name,
        CreatedBy = r.UserId,
        TargetMuscleGroup = r.TargetMuscleGroup,
        Description = r.Description,
        ForceType = r.ForceType,
        Instructions = r.Instructions,
        SecondaryMuscleGroups = r.SecondaryMuscleGroups
    };

    public override ExerciseResponse FromEntity(Domain.Exercise.Exercise e) => new(
        e.Id.ToString(),
        e.Name,
        e.TargetMuscleGroup,
        e.Description,
        e.ForceType,
        e.Instructions,
        e.SecondaryMuscleGroups);
}