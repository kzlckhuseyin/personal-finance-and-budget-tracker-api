public class Transaction
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    //Navigation Property
    public Category Category { get; set; } = null!;
    public User User { get; set; } = null!;
}