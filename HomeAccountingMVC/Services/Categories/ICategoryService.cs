using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Services.Categories
{
    public interface ICategoryService
    {
        bool Create(Category category);
        Task<IList<Category>> GetAllAsync(); 
    }
}
