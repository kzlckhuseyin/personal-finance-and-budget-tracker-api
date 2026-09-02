public interface ICategoryService
{
    Category Create(CategoryCreateDto dto);
    List<Category> GetAll();
    Category? GetById(int id);
    bool Delete(int id);
    Category? Update(CategoryCreateDto dto, int id);
}