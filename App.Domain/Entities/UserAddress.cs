
using App.Domain.Abstractions;
using App.Domain.ViewModel.Request.Address;

namespace App.Domain.Entities;

public class UserAddress : BaseEntity, IAggregateRoot
{
    public string Cep { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int Number { get; set; }

    public void Update(UpdateAddressRequest newAddress)
    {
        if (newAddress != null)
        {
            Cep = newAddress.Cep;
            Street = newAddress.Street;
            Neighborhood = newAddress.Neighborhood;
            City = newAddress.City;
            Number = newAddress.Number;
        }
    }
}
