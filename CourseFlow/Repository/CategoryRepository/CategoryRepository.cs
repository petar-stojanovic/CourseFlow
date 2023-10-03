using CourseFlow.Data;
using CourseFlow.Models;
using CourseFlow.Repository.CourseRepository;
using Microsoft.EntityFrameworkCore;

namespace CourseFlow.Repository.CategoryRepository;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context;
    private DbSet<Category> _categories;

    public CategoryRepository(DataContext dataContext )
    {
        _context = dataContext;
        _categories = _context.Set<Category>();
    }

    public Category AddCategory(Category category)
    {
        _categories.Add(category);
        _context.SaveChanges();
        return category;
    }

    public void DeleteCategory(Category category)
    {
        _categories.Remove(category);
        _context.SaveChanges();
    }

    public List<Category> GetCategories()
    {
        return _categories.ToList();
    }

    public Category GetCategory(Guid id)
    {
        return _categories.Where(c => c.Id == id).FirstOrDefault();
    }

    public Category UpdateCategory(Category category)
    {
        _categories.Update(category);
        _context.SaveChanges();
        return category;
    }
}


