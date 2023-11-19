using Workr.Domain.Exercise;

namespace Workr.Infrastructure.Persistence.Seed;

public static class SystemExerciseData
{
    public static readonly Guid BarbellBenchPressId = Guid.Parse("60a41714-318d-40ba-98a2-dbe5e2ae8bb5");
    public static readonly Guid StandingBarbellCurlId = Guid.Parse("54c07e15-5f68-49b6-9c95-4986c52676f4");
    public static readonly Guid DumbbellGobletSquatId = Guid.Parse("c2a66847-8319-436c-859f-33b7895c4e4f");
    public static readonly Guid DumbbellBicepCurlId = Guid.Parse("04d32bd5-4de6-40bc-89c4-67ee7bcdfaf2");
    public static readonly Guid PushUpId = Guid.Parse("c1cb1145-5e02-4dd1-8983-564ec95a22f4");
    public static readonly Guid RopeTricepExtensionId = Guid.Parse("2627b21a-880f-42fc-8a28-da81e3a4e5ee");

    public static readonly Exercise BarbellBenchPress = new()
    {
        Id = BarbellBenchPressId,
        Name = "Barbell Bench Press",
        Description =
            "The barbell bench press is a classic exercise, known as one of the \"big three\" lifts. The bench press is a compound exercise that targets many of the muscles in your upper body.",
        TargetMuscleGroup = Muscle.Chest,
        SecondaryMuscleGroups = new List<string> { Muscle.Triceps, Muscle.Shoulders },
        ImageUrl = "bench-press-2.png",
        ForceType = ForceType.Push,
        Instructions = new List<string>
        {
            "Lie flat on a bench and set your hands just outside of shoulder width.",
            "Set your shoulder blades by pinching them together and driving them into the bench.",
            "Take a deep breath, lift off and maintain tightness through your upper back.",
            "Inhale and allow the bar to descend slowly by unlocking the elbows.",
            "Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest.",
            "Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows."
        }
    };

    public static readonly Exercise StandingBarbellCurl = new()
    {
        Id = StandingBarbellCurlId,
        Name = "Standing Barbell Curl",
        Description = "The standing barbell curl is the cornerstone of many bicep building routines.",
        TargetMuscleGroup = Muscle.Biceps,
        ImageUrl = "barbell-bicep-curl-1.png",
        ForceType = ForceType.Pull,
        Instructions = new List<string>
        {
            "Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up).",
            "Stand straight up, feet together, back straight, and with your arms fully extended. The bar should not be touching your body.",
            "Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up.",
            "Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position."
        }
    };

    public static readonly Exercise DumbbellGobletSquat = new()
    {
        Id = DumbbellGobletSquatId,
        Name = "Dumbbell Goblet Squat",
        Description =
            "The dumbbell goblet squat is a variation of the squat and is used to build the muscles of the legs. In particular, the dumbbell goblet squat places a lot of emphasis on the quads.",
        TargetMuscleGroup = Muscle.Quads,
        ImageUrl = "dumbbell-squat-1.png",
        ForceType = ForceType.Push,
        Instructions = new List<string>
        {
            "Select a dumbbell and position it at chest height with one hand under each edge of the dumbbell.",
            "Take a deep breath and descend by simultaneously pushing the hips back and bending the knees.",
            "Once your thighs reach parallel with the floor, begin to reverse the movement.",
            "Keep your abs braced and drive your feet through the floor, to get back to the starting position."
        }
    };

    public static readonly Exercise DumbbellBicepCurl = new()
    {
        Id = DumbbellBicepCurlId,
        Name = "Dumbbell Bicep Curl",
        TargetMuscleGroup = Muscle.Biceps,
        ImageUrl = "dumbbell-bicep-curl-1.png",
        ForceType = ForceType.Push,
        Instructions = new List<string>()
    };

    public static readonly Exercise PushUp = new()
    {
        Id = PushUpId,
        Name = "Push Up",
        Description =
            "The push up is an exercise used to target the muscles of the chest. It also indirectly works the muscles of the shoulder, triceps, and core.",
        TargetMuscleGroup = Muscle.Chest,
        SecondaryMuscleGroups = new List<string> { Muscle.Shoulders, Muscle.Triceps, Muscle.Abs },
        ImageUrl = "push-up.png",
        ForceType = ForceType.Push,
        Instructions = new List<string>
        {
        }
    };

    public static readonly Exercise RopeTricepExtension = new()
    {
        Id = RopeTricepExtensionId,
        Name = "Rope Tricep Extension",
        Description = "Test description",
        TargetMuscleGroup = Muscle.Triceps,
        ImageUrl = "cable-machine-tricep-extension-1.png",
        ForceType = ForceType.Push
    };
}