using System.ComponentModel.DataAnnotations;

public class LoginDto
{
    [Required]
    public string Email { get; set; } = string.Empty;
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
}