using Workr.Core;

namespace Workr.Domain.Errors;

public static partial class DomainErrors
{
    private const string WorkoutTemplateBase = nameof(WorkoutTemplate);

    public static class WorkoutTemplate
    {
        public static Error NotFoundById =>
            new($"{WorkoutTemplateBase}.NotFoundById", "Workout template with given ID not found in database");
    }
}