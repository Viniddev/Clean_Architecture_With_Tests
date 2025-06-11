using App.Domain.Entities;
using App.Domain.Enums;

namespace App.Domain.ViewModel.Request.UserInfo;

public class RegisterInformation
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Rg { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public EUserRoles UserRole { get; private set; } = EUserRoles.User;
    public Guid UserAddressId { get; private set; }


    public static RegisterInformation Map(UserInformations user) 
    {
        return new()
        {
            Id = user.Id,
            Name = user.Name,
            Cpf = user.Cpf,
            Rg = user.Rg,
            Email = user.Email,
            Password = user.Password,
            PhoneNumber = user.PhoneNumber,
            UserRole = user.UserRole,
            UserAddressId = user.UserAddressId,
        };
    }
}
