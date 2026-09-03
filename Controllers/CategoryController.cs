using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]
[Authorize]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = _categoryService.GetAll();

        return StatusCode(200, categories);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _categoryService.GetById(id);
        if (category == null)
        {
            return NotFound();
        }
        return StatusCode(200, category);
    }

    [HttpPost]
    public IActionResult Create(CategoryCreateDto dto)
    {
        var category = _categoryService.Create(dto);
        return StatusCode(201, category);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, CategoryCreateDto dto)
    {
        var category = _categoryService.Update(dto, id);
        if (category == null)
        {
            return NotFound();
        }
        return StatusCode(200, category);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        bool result = _categoryService.Delete(id);

        if (!result)
        {
            return NotFound();
        }

        return Ok();
    }
}