using FastEndpoints;
using FluentValidation;
using Workr.Domain;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.Exercise.CreateExercise;

public sealed class CreateExerciseValidator : Validator<CreateExerciseRequest>
{
    public CreateExerciseValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Exercise name is required.");
        
        RuleFor(x => x.TargetMuscleGroup)
            .NotEmpty()
            .WithMessage("Target muscle group is required.");

        RuleFor(x => x.Type)
            .Must(x => ExerciseType.All().Contains(x));
    }
}