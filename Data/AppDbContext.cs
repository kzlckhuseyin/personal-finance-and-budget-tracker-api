using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var fakeUsers = UserSeeder.GetFakeUser(30);
        modelBuilder.Entity<User>().HasData(fakeUsers);
        modelBuilder.Entity<Category>().HasData(CategorySeeder.GetFakeCategories(50, fakeUsers));

    }
}