using Microsoft.EntityFrameworkCore;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        // 1. Bekleyen migration'lar varsa otomatik uygula
        context.Database.Migrate();

        if (!context.Users.Any())
        {
            var fakeUsers = UserSeeder.GetFakeUser(20);
            context.Users.AddRange(fakeUsers);
            context.SaveChanges();
        }

        if (!context.Categories.Any())
        {
            var users = context.Users.ToList();
            var fakeCategories = CategorySeeder.GetFakeCategories(100, users);
            context.Categories.AddRange(fakeCategories);
            context.SaveChanges();
        }

        if (!context.Transactions.Any())
        {
            var categories = context.Categories.ToList();
            var fakeTransaction = TransactionSeeder.GetFakeTransactions(2000, categories);
            context.Transactions.AddRange(fakeTransaction);
            context.SaveChanges();
        }

    }
}