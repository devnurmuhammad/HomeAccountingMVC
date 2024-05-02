using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Repositories.Categories;

namespace HomeAccountingMVC.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public bool Create(Category category)
        {
            _repository.Create(category);
            throw new NotImplementedException();
        }

        public async Task<IList<Category>> GetAllAsync()
        {
            IList<Category> categories = await _repository.GetAllAsync();

            return categories;
        }
    }
}
