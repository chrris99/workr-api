using FastEndpoints;

namespace Workr.Web._Features_.Exercise.GetExerciseById;

public class DemoEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/api/demo");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        foreach (var claim in User.Claims)
        {
            Logger.LogInformation($"{claim.Value}");
        }

        await SendOkAsync(ct);
    }
}