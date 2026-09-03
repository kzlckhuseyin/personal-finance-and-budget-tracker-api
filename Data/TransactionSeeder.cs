using Bogus;

public static class TransactionSeeder
{
    public static List<Transaction> GetFakeTransactions(int count, List<Category> categories)
    {
        Randomizer.Seed = new Random(42);
        var transactionFaker = new Faker<Transaction>("tr")
        .CustomInstantiator(f =>
        {
            var selectedCategory = f.PickRandom(categories);
            return new Transaction
            {
                CategoryId = selectedCategory.Id,
                UserId = selectedCategory.UserId
            };
        })
        .RuleFor(t => t.Amount, f => Math.Round(f.Random.Decimal(50, 5000), 2))
        .RuleFor(t => t.Description, f => f.Commerce.ProductName())
        .RuleFor(t => t.Date, f => f.Date.Past(1).ToUniversalTime());

        return transactionFaker.Generate(count);

    }
}