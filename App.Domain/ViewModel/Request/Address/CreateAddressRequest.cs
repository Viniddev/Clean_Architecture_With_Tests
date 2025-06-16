using System.ComponentModel.DataAnnotations;

namespace App.Domain.ViewModel.Request.Address;

public class CreateAddressRequest
{
    [Required(ErrorMessage = "Cep é obrigatorio")]
    public string Cep { get; set; } = string.Empty;

    [Required(ErrorMessage = "Rua é obrigatorio")]
    public string Street { get; set; } = string.Empty;

    [Required(ErrorMessage = "Bairro é obrigatorio")]
    public string Neighborhood { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cidade é obrigatorio")]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "Número é obrigatorio")]
    public int Number { get; set; }
}
