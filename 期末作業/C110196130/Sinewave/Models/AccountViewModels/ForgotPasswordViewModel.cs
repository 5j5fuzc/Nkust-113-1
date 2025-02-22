using System.ComponentModel.DataAnnotations;

namespace Sinewave.Models.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}