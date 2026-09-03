using Bogus;

public static class CategorySeeder
{
    public static List<Category> GetFakeCategories(int count, List<User> users)
    {
        // Randomizer.Seed sabit tutulmazsa her migration komutunda EF Core verilerin değiştiğini sanır.
        Randomizer.Seed = new Random(42);

        var categoryFaker = new Faker<Category>("tr") // Türkçe sahte veri üretimi için "tr"
        .RuleFor(c => c.Name, f => f.Commerce.Categories(1)[0]) // Bogus Ticari Kategori ismi
        .RuleFor(c => c.Type, f => f.PickRandom("gelir", "gider"))
        .RuleFor(c => c.UserId, f => f.PickRandom(users).Id); // Verilen listeden rastgele seçer

        return categoryFaker.Generate(count);


    }
}