namespace ModelBase_Minimal.Api.Endpoints.Account;

public static class AccountEndpoints
{
    private static string[] Tags = ["Account"];

    public static WebApplication MapAccountEndpoints(this WebApplication app)
    {
        //app.MapPost(ApiEndpointsPaths.Cities, async (CreateCityModel model, IMediator mediator) =>
        //    {

        //        var result = await mediator.Send(model.FromCommand());

        //        ModelResult<CityModel> response = result.FromModel();

        //        return result.CreateResult(response, status201CreatedPath: $"{ApiEndpointsPaths.States}/{result.Data?.Id}");


        //    })
        //    .WithName("CreateCity")
        //    .WithTags(Tags)
        //    .Produces<ModelResult<CityModel>>(StatusCodes.Status201Created)
        //    .Produces<ModelResultBase>(StatusCodes.Status400BadRequest)
        //    .Produces<ModelResultBase>(StatusCodes.Status404NotFound)
        //    .Produces<ModelResultBase>(StatusCodes.Status422UnprocessableEntity);




        return app;
    }
}
