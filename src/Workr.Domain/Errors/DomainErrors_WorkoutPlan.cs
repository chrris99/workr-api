using Workr.Core;

namespace Workr.Domain.Errors;

public static partial class DomainErrors
{
    private const string WorkoutPlanBase = nameof(WorkoutPlan);

    public static class WorkoutPlan
    {
        public static Error NotFoundById =>
            new($"{WorkoutPlanBase}.NotFoundById", "Workout plan with given ID not found in database");

        public static Error Forbidden =>
            new($"{WorkoutPlanBase}.Forbidden", "Forbidden");
    }
}