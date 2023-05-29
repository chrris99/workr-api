using FastEndpoints;

namespace Workr.Web.Features.Exercise;

public sealed class ExerciseResponseMapper : ResponseMapper<ExerciseResponse, Domain.Exercise.Exercise>
{
    public override ExerciseResponse FromEntity(Domain.Exercise.Exercise e) => new(
        e.Id.ToString(),
        e.Name,
        e.TargetMuscleGroup,
        e.Description,
        e.ForceType,
        e.Instructions,
        e.SecondaryMuscleGroups);
}