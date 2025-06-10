using App.Application.Usecases.Authentication;
using Microsoft.Extensions.DependencyInjection;
using App.Domain.Services;
using App.Application.Usecases.UserData;
using App.Domain.Services.Base;

namespace App.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service) 
    {
        service.AddTransient<IAuthenticationService, AuthenticationService>();
        service.AddTransient<IUserService, UserService>();

        return service;
    }
}
