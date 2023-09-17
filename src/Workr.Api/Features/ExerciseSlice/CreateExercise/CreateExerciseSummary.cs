using FastEndpoints;
using Workr.Domain.Exercise;

namespace Workr.Web.Features.ExerciseSlice.CreateExercise;

public class CreateExerciseSummary : Summary<CreateExerciseEndpoint>
{
    public CreateExerciseSummary()
    {
        Summary = "Create a new exercise";
        Description = "Create a new exercise";

        ExampleRequest = new CreateExerciseRequest
        {
            Name = "Barbell Bench Press",
            Description = "The barbell bench press is a classic exercise popular among all weight lifting circles.",
            ForceType = "Push (Bilateral)",
            TargetMuscleGroup = "Chest",
            SecondaryMuscleGroups = new List<string>
            {
                "Shoulders",
                "Triceps"
            },
            Instructions = new List<string>
            {
                "Lie flat on a bench and set your hands just outside of shoulder width.",
                "Set your shoulder blades by pinching them together and driving them into the bench.",
                "Take a deep breath and allow your spotter to help you with the lift off in order to maintain tightness through your upper back.",
                "Let the weight settle and ensure your upper back remains tight after lift off.",
                "Inhale and allow the bar to descend slowly by unlocking the elbows.",
                "Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest.",
                "Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows.",
                "Repeat for the desired number of repetitions."
            }
        };

        Responses[200] = "Success";
        Responses[400] = "Bad Request";
        Responses[401] = "Forbidden";
        Responses[403] = "Unauthorized";
    }
}