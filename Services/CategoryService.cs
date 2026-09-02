public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;
    public CategoryService(AppDbContext context)
    {
        _context = context;
    }

    public Category Create(CategoryCreateDto dto)
    {
        var category = new Category
        {
            Name = dto.Name,
            Type = dto.Type
        };

        _context.Categories.Add(category);
        _context.SaveChanges();
        return category;
    }

    public bool Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(x => x.Id == id);
        if (category == null)
        {
            return false;
        }
        _context.Categories.Remove(category);
        _context.SaveChanges();
        return true;
    }

    public List<Category> GetAll()
    {
        var categories = _context.Categories.ToList();
        return categories;
    }

    public Category? GetById(int id)
    {
        var category = _context.Categories.FirstOrDefault(x => x.Id == id);
        if (category == null)
        {
            return null;
        }
        return category;
    }

    public Category? Update(CategoryCreateDto dto, int id)
    {
        var category = _context.Categories.FirstOrDefault(x => x.Id == id);
        if (category == null)
        {
            return null;
        }
        category.Name = dto.Name;
        category.Type = dto.Type;
        _context.SaveChanges();
        return category;
    }
}