using App.Domain.Services.Base;
using App.Domain.ViewModel.Request.UserInfo;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.V1;

public static class AuthenticationController
{
    public static void MapAuthenticationEndpoints(this IEndpointRouteBuilder map)
    {
        var group = map.MapGroup("api/v1/");

        group.MapPost("login", LoginAsync);
        group.MapPost("create-user", RegisterAsync);
    }

    public static async Task<IResult> RegisterAsync(
        [FromServices] IAuthenticationService _userService,
        [FromBody] RegisterInformation registryInformation,
        CancellationToken cancellationToken
    )
    {
        if (registryInformation == null)
            return Results.BadRequest("Registry informations cannot be null");

        var result = await _userService.CreateUserServiceAsync(registryInformation, cancellationToken);
        
        if(result.Data is not null)
            return Results.Ok(result);
        else
            return Results.BadRequest(result);
    }

    public static async Task<IResult> LoginAsync(
        [FromServices] IAuthenticationService _userService,
        [FromBody] LoginInformations login,
        CancellationToken cancellationToken
    ) 
    {
        if (login == null)
            return Results.BadRequest("Login informations cannot be null");

        var result = await _userService.LoginServiceAsync(login, cancellationToken);

        if (result.Data is not null)
            return Results.Ok(result);
        else
            return Results.BadRequest(result);
    }
}
