using FastEndpoints;

namespace Workr.Web.Features.Exercise.UpdateExercise;

public sealed class UpdateExerciseMapper : Mapper<UpdateExerciseRequest, ExerciseResponse, Domain.Exercise.Exercise>
{
    public override Domain.Exercise.Exercise ToEntity(UpdateExerciseRequest r) => new()
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

    public override ExerciseResponse FromEntity(Domain.Exercise.Exercise e)
    {
        return base.FromEntity(e);
    }


}