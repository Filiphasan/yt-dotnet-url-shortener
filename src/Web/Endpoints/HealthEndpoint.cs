using Carter;

namespace Web.Endpoints;

public class HealthEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/health-check");
        group.MapGet("", () => "Healthy");
    }
}