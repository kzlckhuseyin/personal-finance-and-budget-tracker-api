public interface ITransactionService
{
    List<Transaction> GetAll();
    Transaction? GetById(int id);
    TransactionResponseDto? Create(TransactionCreateDto dto);
    Transaction? Update(int id, TransactionCreateDto dto);
    bool Delete(int id);
}