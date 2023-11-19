using System.Security.Cryptography.X509Certificates;

namespace Workr.Domain.Accessory;

public static class EquipmentType
{
    public static Guid KetllebellId = Guid.NewGuid();
    public static Guid DumbbellId = Guid.NewGuid();
    public static Guid BarbellId = Guid.NewGuid();

    public static Equipment Kettlebell => new()
    {
        Id = KetllebellId,
        Name = nameof(Kettlebell),
        Weight = true
    };

    public static Equipment Dumbbell => new()
    {
        Id = DumbbellId,
        Name = nameof(Dumbbell),
        Weight = true
    };

    public static Equipment Barbell => new()
    {
        Id = BarbellId,
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