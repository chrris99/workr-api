namespace Workr.Domain.Accessory;

public static class EquipmentType
{
    public static Equipment Kettlebell => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Kettlebell),
        Weight = true
    };

    public static Equipment Dumbbell => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Dumbbell),
        Weight = true
    };

    public static Equipment Barbell => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Barbell),
        Weight = true
    };

    public static Equipment Treadmill => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Treadmill),
        Weight = false
    };

    public static Equipment Bar => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Bar),
        Weight = false
    };

    public static Equipment Bike => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(Bike),
        Weight = false
    };

    public static Equipment JumpRope => new()
    {
        Id = Guid.NewGuid(),
        Name = nameof(JumpRope),
        Weight = false
    };
}