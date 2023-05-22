using FastEndpoints;
using Workr.Web._Features_.Exercise.CreateExercise;

namespace Workr.Web._Features_.Exercise;

public sealed class ExerciseMapper : Mapper<CreateExerciseRequest, ExerciseResponse, Domain.Exercise>
{
    public override Domain.Exercise ToEntity(CreateExerciseRequest r) => new()
    {
        Name = r.Name,
        Description = r.Description
    };

    public override ExerciseResponse FromEntity(Domain.Exercise e) => new(e.Name, e.Description);
}