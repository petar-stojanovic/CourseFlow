using CourseFlow.Models;
using CourseFlow.Repository.CategoryRepository;
using Microsoft.AspNetCore.Mvc;

namespace CourseFlow.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    [HttpGet("")]
    public ActionResult<List<Category>>  Get()
    {
        return _categoryRepository.GetCategories();
    }
}