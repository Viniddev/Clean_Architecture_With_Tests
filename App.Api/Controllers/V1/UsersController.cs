using App.Domain.Services;
using App.Domain.ViewModel.Request;
using App.Domain.ViewModel.Request.UserInfo;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers.V1;

public static class UsersController
{
    public static void MapUsersEndpoints(this IEndpointRouteBuilder map) 
    {
        var group = map.MapGroup("api/v1/users/");

        group.MapPut("getAll", GetAll);
        group.MapGet("getById/{Id}", GetById);
        group.MapPut("update", UpdateInformations);
        group.MapDelete("delete/{Id}", Delete);
    }

    public static async Task<IResult> GetAll(
        [FromBody] PagedRequest request, 
        [FromServices] IUserService _userService, 
        CancellationToken cancellationToken
    ) 
    {
        var response = await _userService.GetAllUsersService(request, cancellationToken);

        if (response.Data is not null)
            return Results.Ok(response);
        else
            return Results.NoContent();
    }

    public static async Task<IResult> GetById(
        [FromRoute] Guid Id, 
        [FromServices] IUserService _userService,
        CancellationToken cancellationToken
    )
    {
        var response = await _userService.GetUserByIdService(Id, cancellationToken);

        if (response.Data is not null)
            return Results.Ok(response);
        else
            return Results.NoContent();
    }

    public static async Task<IResult> UpdateInformations(
        [FromBody] RegisterInformation request,
        [FromServices] IUserService _userService,
        CancellationToken cancellationToken
    )
    {
        var response = await _userService.UpdateUserService(request, cancellationToken);

        if (response.Data == true)
            return Results.Ok(response);
        else
            return Results.NoContent();
    }

    public static async Task<IResult> Delete(
        [FromRoute] Guid Id,
        [FromServices] IUserService _userService,
        CancellationToken cancellationToken
    )
    {
        var response = await _userService.DeleteUserService(Id, cancellationToken);

        if (response.Data)
            return Results.Ok(response);
        else
            return Results.NoContent();
    }
}
