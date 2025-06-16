using App.Domain.Entities;
using App.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.ViewModel.Request.UserInfo;

public class RegisterInformation
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Cpf { get; set; } = string.Empty;
    [Required] 
    public string Rg { get; set; } = string.Empty;
    [Required] 
    public string Email { get; set; } = string.Empty;
    [Required] 
    public string Password { get; set; } = string.Empty;
    [Required] 
    public string PhoneNumber { get; set; } = string.Empty;
    [Required] 
    public EUserRoles UserRole { get; private set; } = EUserRoles.User;
    [Required] 
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
