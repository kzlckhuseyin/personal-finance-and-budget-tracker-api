public class TransactionService : ITransactionService
{
    private readonly AppDbContext _context;
    private readonly ICurrentUserService _currentUserService;

    public TransactionService(AppDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }
    public TransactionResponseDto? Create(TransactionCreateDto dto)
    {
        int currentUserId = _currentUserService.GetUserId();
        var category = _context.Categories.FirstOrDefault(x => x.Id == dto.CategoryId);
        if (category == null || category.UserId != currentUserId)
        {
            return null;
        }

        var transaction = new Transaction
        {
            UserId = currentUserId,
            CategoryId = dto.CategoryId,
            Amount = dto.Amount,
            Description = dto.Description,
            Date = dto.Date
        };

        _context.Transactions.Add(transaction);
        _context.SaveChanges();
        return new TransactionResponseDto
        {
            Id = transaction.Id,
            Amount = transaction.Amount,
            Description = transaction.Description,
            Date = transaction.Date,
            CategoryId = transaction.CategoryId,
            CategoryName = category.Name
        };
    }

    public bool Delete(int id)
    {
        int currentUserId = _currentUserService.GetUserId();
        var transaction = _context.Transactions.FirstOrDefault(x => x.Id == id);
        if (transaction == null || transaction.UserId != currentUserId)
        {
            return false;
        }

        _context.Transactions.Remove(transaction);
        _context.SaveChanges();
        return true;
    }

    public List<Transaction> GetAll()
    {
        int currentUserId = _currentUserService.GetUserId();
        var transactions = _context.Transactions.Where(t => t.UserId == currentUserId)
        .OrderByDescending(t => t.Date)
        .ToList();

        return transactions;
    }

    public Transaction? GetById(int id)
    {
        int currentUserId = _currentUserService.GetUserId();
        var transaction = _context.Transactions.FirstOrDefault(x => x.Id == id);

        if (transaction == null || transaction.UserId != currentUserId)
        {
            return null;
        }

        return transaction;
    }

    public Transaction? Update(int id, TransactionCreateDto dto)
    {
        int currentUserId = _currentUserService.GetUserId();
        var transaction = _context.Transactions.FirstOrDefault(x => x.Id == id);
        var category = _context.Categories.FirstOrDefault(x => x.Id == dto.CategoryId);

        if (category == null || category.UserId != currentUserId)
        {
            return null;
        }

        if (transaction == null || transaction.UserId != currentUserId)
        {
            return null;
        }

        transaction.CategoryId = dto.CategoryId;
        transaction.Amount = dto.Amount;
        transaction.Description = dto.Description;
        transaction.Date = dto.Date;

        _context.SaveChanges();
        return transaction;
    }
}