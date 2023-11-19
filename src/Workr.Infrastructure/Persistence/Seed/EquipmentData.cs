using Workr.Domain.Accessory;

namespace Workr.Infrastructure.Persistence.Seed;

public static class EquipmentData
{
    public static readonly Guid KetllebellId = Guid.Parse("2af529f3-728b-4f68-ad13-7854775f08d7");
    public static readonly Guid DumbbellId = Guid.Parse("c1d36df2-0674-4f21-ba67-9f7b4c0d971b");
    public static readonly Guid BarbellId = Guid.Parse("4c9e1eb0-6ab5-44a6-b8dd-e1a9ff4c41bd");
    public static readonly Guid TreadmillId = Guid.Parse("1e5e3259-d9dc-4101-b042-231ea31c4744");
    public static readonly Guid BarId = Guid.Parse("933463e2-bc2d-40c0-bcb8-95c0116e4472");
    public static readonly Guid BikeId = Guid.Parse("b12affcf-4498-4423-b505-7bef0129a6f5");
    public static readonly Guid JumpRopeId = Guid.Parse("422e35ec-7c4f-4304-abef-8e44f73080e9");
    public static readonly Guid CableId = Guid.Parse("b634ea02-7da8-4939-a617-3dea58119d96");

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
        Id = TreadmillId,
        Name = nameof(Treadmill),
        Weight = false
    };

    public static Equipment Bar => new()
    {
        Id = BarId,
        Name = nameof(Bar),
        Weight = false
    };

    public static Equipment Bike => new()
    {
        Id = BikeId,
        Name = nameof(Bike),
        Weight = false
    };

    public static Equipment JumpRope => new()
    {
        Id = JumpRopeId,
        Name = nameof(JumpRope),
        Weight = false
    };

    public static Equipment Cable => new()
    {
        Id = CableId,
        Name = nameof(Cable),
        Weight = true
    };
}