using HomeAccountingMVC.Db_Context;
using HomeAccountingMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAccountingMVC.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(Category category)
        {
            _context.Categories.Add(category);
            int result = _context.SaveChanges();

            return result > 0;
        }

        public async Task<IList<Category>> GetAllAsync()
        {
            IList<Category> categories = await _context.Categories.ToListAsync();

            return categories;
        }
    }
}
