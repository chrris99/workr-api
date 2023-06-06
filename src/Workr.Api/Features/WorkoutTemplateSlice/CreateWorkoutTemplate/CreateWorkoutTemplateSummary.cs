using FastEndpoints;

namespace Workr.Web.Features.WorkoutTemplateSlice.CreateWorkoutTemplate;

public sealed class CreateWorkoutTemplateSummary : Summary<CreateWorkoutTemplateEndpoint>
{
    public CreateWorkoutTemplateSummary()
    {
        Summary = "Create a new workout template";
        Description = "Create a new workout template";

        ExampleRequest = new CreateWorkoutTemplateRequest
        {
            Name = "Push Workout",
            Description = "Workout mostly focusing on training the chest, triceps and shoulders",
            BlockTemplateRequests = new List<CreateWorkoutBlockTemplateRequest>
            {
                new()
                {
                    Order = 1,
                    ItemTemplateRequests = new List<CreateWorkoutItemTemplateRequest>
                    {
                        new()
                        {
                            ExerciseId = new Guid("7f20b718-b43b-450e-812c-050fd85cb6f7"),
                            Sets = 3,
                            Reps = 12,
                            Order = 1
                        },
                        new()
                        {
                            ExerciseId = new Guid("4b03711f-9eef-475f-87df-60f75e8bccba"),
                            Sets = 3,
                            Reps = 12,
                            Order = 2
                        }
                    }
                },
                new()
                {
                    Order = 2,
                    ItemTemplateRequests = new List<CreateWorkoutItemTemplateRequest>
                    {
                        new()
                        {
                            ExerciseId = new Guid("94aa32f2-0daa-432b-80ef-520cd359997a"),
                            Sets = 3,
                            Reps = 8,
                            Order = 1
                        }
                    }
                }
            }
        };

        Responses[200] = "Success";
        Responses[400] = "Bad Request";
        Responses[401] = "Forbidden";
        Responses[403] = "Unauthorized";
    }
}