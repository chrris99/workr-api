using FastEndpoints;
using FluentValidation.Results;

namespace Workr.Web.Processors;

public sealed class RequestLogger<TRequest> : IPreProcessor<TRequest>
{
    public Task PreProcessAsync(TRequest req, HttpContext ctx, List<ValidationFailure> failures, CancellationToken ct)
    {
        var logger = ctx.Resolve<ILogger<TRequest>>();

        logger.LogInformation("Receiving {method} {path} request", ctx.Request.Method, ctx.Request.Path.Value);
        
        return Task.CompletedTask;
    }
}