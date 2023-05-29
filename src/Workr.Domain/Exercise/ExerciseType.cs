namespace Workr.Domain.Exercise;

public static class ExerciseType
{
    public static readonly string Repeated = "Repeated";
    public static readonly string Timed = "timed";
    public static readonly string Tempo = "tempo";

    public static List<string> All()
    {
        return new List<string>
        {
            Repeated,
            Timed,
            Tempo
        };
    }
}