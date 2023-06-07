using Workr.Core;

namespace Workr.Domain.Errors;

public static partial class DomainErrors
{
    private const string WorkoutBase = nameof(Workout);

    public static class Workout
    {
        public static Error NotFoundById =>
            new($"{WorkoutBase}.NotFoundById", "Workout with given ID not found in database");

        public static Error Forbidden =>
            new($"{WorkoutBase}.Forbidden", "Forbidden");
    }
}