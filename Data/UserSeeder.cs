using Bogus;

public static class UserSeeder
{
    private static readonly DateTime FixedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    // BCrypt için 29 karakterlik sabit Salt ($2a$11$ + 22 karakter)
    private static readonly string FixedSalt = "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e";

    public static List<User> GetFakeUser(int count)
    {
        Randomizer.Seed = new Random(42);

        int start_id = 10;

        // Sabit salt sayesinde bu metod HER ZAMAN aynı Hash çıktısını üretir:
        var passwordHash = BCrypt.Net.BCrypt.HashPassword("123456789", FixedSalt);

        var userFaker = new Faker<User>("tr")
            .RuleFor(c => c.Id, f => start_id++)
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PasswordHash, passwordHash)
            .RuleFor(c => c.CreatedAt, _ => FixedDate);

        return userFaker.Generate(count);
    }
}