namespace App.Domain.ViewModel.Response.Address;

public class AddressResponse
{
    public Guid Id { get; init; }
    public DateTime CreationDate { get; init; }
    public string Cep { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int Number { get; set; }
}
