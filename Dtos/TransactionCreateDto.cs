using System.ComponentModel.DataAnnotations;

public class TransactionCreateDto
{
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    [Required]
    public DateTime Date { get; set; } = DateTime.UtcNow;
}