using Bogus;

public static class UserSeeder
{
    public static List<User> GetFakeUser(int count)
    {
        Randomizer.Seed = new Random(42);

        // Sabit salt sayesinde bu metod HER ZAMAN aynı Hash çıktısını üretir:
        var passwordHash = BCrypt.Net.BCrypt.HashPassword("123456789");

        var userFaker = new Faker<User>("tr")
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PasswordHash, passwordHash)
            .RuleFor(c => c.CreatedAt, f => f.Date.Past(1).ToUniversalTime());

        return userFaker.Generate(count);
    }
}