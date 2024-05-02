using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Repositories.Categories
{
    public interface ICategoryRepository
    {
        bool Create(Category category);
        Task<IList<Category>> GetAllAsync();
    }
}
