namespace Workr.Domain.Accessory;

public sealed class Equipment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Weight { get; set; }
    public List<Exercise.Exercise> Exercises { get; set; } = new();
}