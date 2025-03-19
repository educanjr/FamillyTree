using FamilyTree.Web.ConfigOptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System.IO;

namespace FamilyTree.Web.Middleware;

public class ClientIdMiddleware
{
    private readonly RequestDelegate _next;
    private readonly RequiredHeaderConfig _headersConfig;

    public ClientIdMiddleware(RequestDelegate next, IOptions<RequiredHeaderConfig> headersConfig)
    {
        _next = next;
        _headersConfig = headersConfig.Value;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Exclude Swagger requests from validation
        var path = context.Request.Path.Value?.ToLower();
        if (path != null && (path.StartsWith("/swagger") || path.StartsWith("/swagger/index.html")))
        {
            await _next(context);
            return;
        }

        if (!context.Request.Headers.TryGetValue("x-client-id", out StringValues clientId))
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsync("Missing x-client-id header");
            return;
        }

        if (!_headersConfig.AllowedClientIds.Contains(clientId.ToString()))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Invalid x-client-id");
            return;
        }

        await _next(context);
    }
}
