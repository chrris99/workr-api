using FastEndpoints;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.ExerciseSlice;

public sealed class ExerciseResponseMapper : ResponseMapper<ExerciseResponse, Exercise>
{
    public override ExerciseResponse FromEntity(Exercise e) => new(
        e.Id.ToString(),
        e.Name,
        e.TargetMuscleGroup,
        e.Description,
        e.ForceType,
        e.Instructions,
        e.SecondaryMuscleGroups);
}