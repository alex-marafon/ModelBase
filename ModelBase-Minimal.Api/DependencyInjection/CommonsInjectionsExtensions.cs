using ModelBase_Minimal.Api.Endpoints.Account;

namespace ModelBase_Minimal.Api.DependencyInjection;

public static class CommonsInjectionsExtensions
{
    public static WebApplication MapApiEndPoints(this WebApplication app)
    {
        app
            .MapAccountEndpoints();

        return app;
    }
}
